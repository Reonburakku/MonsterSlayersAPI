using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models;
using MonsterSlayersAPI.BLL.Models.Battle;
using MonsterSlayersAPI.BLL.Models.Request.Base;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Result;
using MonsterSlayersAPI.BLL.Services.Base;
using MonsterSlayersAPI.BLL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Services
{
    public class BattleService : BaseService, IBattleService
    {

        internal IBattleRepository _battleRepository;
        public BattleService(IUnitOfWork unitOfWork, IMapper mapper, IBattleRepository battleRepository) : base(unitOfWork, mapper)
        {
            _battleRepository = battleRepository;
        }

        public async Task<BattleResultModel> GetBattleByIdAsync(GetBattleByIdModel model)
        {
            _unitOfWork.Source = model.Origin;
            return await GetBattleById(model, "");
        }

        public async Task<BattleResultModel> EndTurn(EndTurnModel model)
        {
            _unitOfWork.Source = model.Origin;
            MonsterTurnModel monsterTurnModel = new MonsterTurnModel();
            Battle battle = await _unitOfWork.BattleRepository.GetByIdAsync(model.BattleId, model.LanguageId);
            BattleParticipant battleParticipant = battle.BattleParticipants.First(x => x.CreatureId == model.CreatureId);
            GetBattleByIdModel getBattleByIdModel = new GetBattleByIdModel
            {
                Id = battle.BattleId,
                LanguageId = model.LanguageId
            };
            if (battle.EndDate != null)
            {
                return await GetBattleById(getBattleByIdModel, "Batalla Terminada");
            }
            if (battle.Turn != battleParticipant.Order)
            {
                return new BattleResultModel
                {
                    Message = "No es tu turno"
                };
            }

            CharacterBattleModel character = JsonSerializer.Deserialize<CharacterBattleModel>(battleParticipant.ParticipantData);
            Character originalCharacter = await _unitOfWork.CharacterRepository.GetByIdAsync(character.CharacterId);
            character.Stamina = originalCharacter.Stamina;
            battleParticipant.ParticipantData = JsonSerializer.Serialize(character);

            bool characterTurn = false;

            while (!characterTurn)
            {
                battle.Turn++;
                if (battle.Turn > battle.BattleParticipants.Count())
                {
                    battle.Turn = 1;
                    battle.Round++;
                }
                _unitOfWork.BattleRepository.Update(battle);
                BattleParticipant actualBattleParticipant = battle.BattleParticipants.First(x => x.Order == battle.Turn);
                if (actualBattleParticipant.IsMonster)
                {
                    monsterTurnModel.BattleId = model.BattleId;
                    monsterTurnModel.MonsterModel = JsonSerializer.Deserialize<MonsterBattleModel>(actualBattleParticipant.ParticipantData);
                    monsterTurnModel.BattleParticipants = battle.BattleParticipants;
                    monsterTurnModel.Origin = model.Origin;
                    monsterTurnModel.LanguageId = model.LanguageId;
                    monsterTurnModel.Turn = battle.Turn ?? 0;
                    monsterTurnModel.Round = battle.Round;

                    monsterTurnModel = await MonsterTurnAsync(monsterTurnModel);


                    actualBattleParticipant.ParticipantData = JsonSerializer.Serialize(monsterTurnModel.MonsterModel);
                    battle.BattleParticipants = monsterTurnModel.BattleParticipants;

                    if (monsterTurnModel.Win)
                    {
                        EndBattleModel endBattleModel = new EndBattleModel()
                        {
                            BattleId = battle.BattleId,
                            LanguageId = model.LanguageId,
                            Origin = model.Origin,
                            TeamWinner = actualBattleParticipant.Team
                        };
                        return await EndBattleAsync(endBattleModel);
                    }
                }
                else
                {
                    characterTurn = true;
                }
            }
            
            _unitOfWork.CommitAsync();

            return await GetBattleByIdAsync(getBattleByIdModel);
        }

        public async Task<BattleResultModel> StartBattle(StartBattleModel model)
        {
            _unitOfWork.Source = model.Origin;
            List<BattleParticipant> battleParticipants = new List<BattleParticipant>();

            Battle battle = _mapper.Map<Battle>(model);
            battle.Turn = 1;
            battle.Round = 1;

            IEnumerable<Character> characters = await _unitOfWork.CharacterRepository.GetByIdRangeAsync(model.CharactersIds, model.LanguageId);
            if (characters.Count() < model.CharactersIds.Count())
            {
                return new BattleResultModel
                {
                    Message = "No hay personajes"
                };
            }
            IEnumerable<Monster> monsters = await _unitOfWork.MonsterRepository.GetByIdRangeAsync(model.MonstersIds, model.LanguageId);
            if (monsters.Count() < model.MonstersIds.Count())
            {
                return new BattleResultModel
                {
                    Message = "No hay monstruos"
                };
            }

            List<Tuple<int, int, string, bool>> creatures = new List<Tuple<int, int, string, bool>>();
            foreach (var character in characters)
            {
                creatures.Add(new Tuple<int, int, string, bool>(character.CreatureId, character.Speed, "A", false));
            }
            foreach (var monster in monsters)
            {
                creatures.Add(new Tuple<int, int, string, bool>(monster.CreatureId, monster.Speed, "B", true));
            }
            creatures.OrderByDescending(x => x.Item2);
            int ord = 1;
            foreach (Tuple<int, int, string, bool> item in creatures)
            {
                battleParticipants.Add(new BattleParticipant
                {
                    Team = item.Item3,
                    CreatureId = item.Item1,
                    Order = ord,
                    IsMonster = item.Item4,
                    ParticipantData = GetSerializedParticipant(item.Item4, monsters.FirstOrDefault(x => x.CreatureId == item.Item1), characters.FirstOrDefault(x => x.CreatureId == item.Item1))
                });
                ord++;
            }

            battle.BattleParticipants = battleParticipants;
            battle.StartDate = DateTime.Now;

            battle = await _unitOfWork.BattleRepository.Save(battle);

            GetBattleByIdModel getBattleByIdModel = new GetBattleByIdModel
            {
                Id = battle.BattleId,
                LanguageId = model.LanguageId
            };
            return await GetBattleById(getBattleByIdModel, "Battle started");
        }

        public async Task<BattleResultModel> UseAbility(UseAbilityModel model)
        {
            _unitOfWork.Source = model.Origin;
            Battle battle = await _unitOfWork.BattleRepository.GetByIdAsync(model.BattleId, model.LanguageId);GetBattleByIdModel getBattleByIdModel = new GetBattleByIdModel
            {
                Id = battle.BattleId,
                LanguageId = model.LanguageId
            };
            if (battle.EndDate != null)
            {
                return await GetBattleById(getBattleByIdModel, "Batalla terminada");
            }
            Ability ability = await _unitOfWork.AbilityRepository.GetByIdAsync(model.AbilityId, model.LanguageId);

            BattleParticipant sourceBattleParticipant = battle.BattleParticipants.First(x => x.CreatureId == model.sourceCreatureId);
            CharacterBattleModel sourceCreature = JsonSerializer.Deserialize<CharacterBattleModel>(sourceBattleParticipant.ParticipantData);

            BattleParticipant targetBattleParticipant = battle.BattleParticipants.First(x => x.CreatureId == model.TargetCreatureId);
            

            sourceCreature.Stamina -= ability.StaminaCost;
            if (sourceCreature.Stamina < 0)
            {
                return new BattleResultModel
                {
                    Message = "No tiene Estamina suficiente"
                };
            }


            sourceCreature.Mana -= ability.ManaCost;
            if (sourceCreature.Mana < 0)
            {
                return new BattleResultModel
                {
                    Message = "No tiene maná suficiente"
                };
            }


            CharacterSkill characterSkill = await _unitOfWork.CharacterSkillRepository.GetByCharacterIdSkillIdAsync(sourceCreature.CharacterId, ability.SkillId, model.LanguageId);

            bool isCrit = UtilityFunctions.IsCritic(sourceCreature.CritRate);
            int damageCount = characterSkill.Real;
            int damage = UtilityFunctions.DiceDamage(ability.DamageDice, damageCount);
            damage = isCrit ? damage * sourceCreature.CritDamage : damage;
            double resistance = 0;
            double realDamage = 0;

            if (targetBattleParticipant.IsMonster)
            {
                MonsterBattleModel target = JsonSerializer.Deserialize<MonsterBattleModel>(targetBattleParticipant.ParticipantData);
                resistance = target.ResistanceBattleModels.First(x => x.DamageTypeId == ability.DamageTypeId).Resistance;
                realDamage = UtilityFunctions.AplyResistance(damage, resistance);
                target.HP = (int)(target.HP - realDamage);

                targetBattleParticipant.ParticipantData = JsonSerializer.Serialize(target);

                if (target.HP <= 0)
                {
                    EndBattleModel endBattleModel = new EndBattleModel()
                    {
                        BattleId = battle.BattleId,
                        LanguageId = model.LanguageId,
                        Origin = model.Origin,
                        TeamWinner = targetBattleParticipant.Team
                    };
                    return await EndBattleAsync(endBattleModel);
                }
            }
            else
            {
                CharacterBattleModel target = JsonSerializer.Deserialize<CharacterBattleModel>(targetBattleParticipant.ParticipantData);
                resistance = target.ResistanceBattleModels.First(x => x.DamageTypeId == ability.DamageTypeId).Resistance;
                realDamage = UtilityFunctions.AplyResistance(damage, resistance);
                target.HP = (int)(target.HP - realDamage);

                targetBattleParticipant.ParticipantData = JsonSerializer.Serialize(target);

                if (target.HP <= 0)
                {
                    EndBattleModel endBattleModel = new EndBattleModel()
                    {
                        BattleId = battle.BattleId,
                        LanguageId = model.LanguageId,
                        Origin = model.Origin,
                        TeamWinner = targetBattleParticipant.Team
                    };
                    return await EndBattleAsync(endBattleModel);
                }
            }

            sourceBattleParticipant.ParticipantData = JsonSerializer.Serialize(sourceCreature);




            BattleAction battleAction = new BattleAction
            {
                AbilityId = ability.AbilityId,
                BattleId = model.BattleId,
                Value = realDamage,
                Round = battle.Round,
                Turn = battle.Turn,
                BattleActionAffecteds = new List<BattleActionAffected>
                {
                    new BattleActionAffected
                    {
                        CreatureId = sourceCreature.CreatureId,
                        Type = "Source",
                    },
                    new BattleActionAffected
                    {
                        CreatureId = targetBattleParticipant.CreatureId,
                        Type = "Target",
                    }
                },
            };

            await _unitOfWork.BattleActionRepository.Save(battleAction);
            _unitOfWork.CommitAsync();


            
            return await GetBattleById(getBattleByIdModel, "Success");
        }



        private string GetSerializedParticipant(bool isMonster, Monster? monster, Character? character)
        {
            if (isMonster)
            {
                MonsterBattleModel monsterBattleModel = _mapper.Map<MonsterBattleModel>(monster);
                monsterBattleModel.ResistanceBattleModels = _mapper.Map<List<ResistanceBattleModel>>(monster.MonsterResistances);
                return JsonSerializer.Serialize(monsterBattleModel);
            }
            else
            {
                CharacterBattleModel characterBattleModel = _mapper.Map<CharacterBattleModel>(character);
                characterBattleModel.ResistanceBattleModels = _mapper.Map<List<ResistanceBattleModel>>(character.CharacterResistances);
                return JsonSerializer.Serialize(characterBattleModel);
            }
        }

        private async Task<MonsterTurnModel> MonsterTurnAsync(MonsterTurnModel monsterTurnModel)
        {
            IEnumerable<MonsterAbility> monsterAbilities = await _unitOfWork.MonsterAbilityRepository.GetAllByMonsterIdAsync(monsterTurnModel.MonsterModel.MonsterId, monsterTurnModel.LanguageId);

            bool hasAbilities = true;
            var rand = new Random();
            int totalStamina = monsterTurnModel.MonsterModel.Stamina;

            while (hasAbilities && !monsterTurnModel.Win)
            {
                IEnumerable<MonsterAbility> availableAbilities = monsterAbilities.Where(x => x.Ability.StaminaCost <= monsterTurnModel.MonsterModel.Stamina && x.Ability.ManaCost <= monsterTurnModel.MonsterModel.Mana);
                hasAbilities = availableAbilities.Any();
                if (hasAbilities)
                {
                    MonsterAbility abilityToUse = availableAbilities.GetRandomElement();
                    BattleParticipant target = monsterTurnModel.BattleParticipants.Where(x => x.Team == "A").GetRandomElement();

                    CharacterBattleModel targetCharacter = JsonSerializer.Deserialize<CharacterBattleModel>(target.ParticipantData);



                    monsterTurnModel.MonsterModel.Stamina -= abilityToUse.Ability.StaminaCost;
                    monsterTurnModel.MonsterModel.Mana -= abilityToUse.Ability.ManaCost;


                    bool isCrit = UtilityFunctions.IsCritic(monsterTurnModel.MonsterModel.Nivel);
                    int damageCount = isCrit ? monsterTurnModel.MonsterModel.Nivel * 2 : monsterTurnModel.MonsterModel.Nivel;
                    double damage = UtilityFunctions.DiceDamage(abilityToUse.Ability.DamageDice, damageCount);

                    double resistance = targetCharacter.ResistanceBattleModels.First(x => x.DamageTypeId == abilityToUse.Ability.DamageTypeId).Resistance;
                    double realDamage = UtilityFunctions.AplyResistance(damage, resistance);
                    targetCharacter.CurrentHP = (int)(targetCharacter.CurrentHP - realDamage);

                    if (targetCharacter.CurrentHP <= 0)
                    {
                        monsterTurnModel.Win = true;
                    }

                    target.ParticipantData = JsonSerializer.Serialize(targetCharacter);

                    BattleAction battleAction = new BattleAction
                    {
                        AbilityId = abilityToUse.Ability.AbilityId,
                        BattleId = monsterTurnModel.BattleId,
                        Value = realDamage,
                        Round = monsterTurnModel.Round,
                        Turn = monsterTurnModel.Turn,
                        BattleActionAffecteds = new List<BattleActionAffected>
                        {
                            new BattleActionAffected
                            {
                                CreatureId = monsterTurnModel.MonsterModel.CreatureId,
                                Type = "Source",
                            },
                            new BattleActionAffected
                            {
                                CreatureId = targetCharacter.CreatureId,
                                Type = "Target",
                            }
                        },
                    };
                    await _unitOfWork.BattleActionRepository.Save(battleAction);
                }
            }
            monsterTurnModel.MonsterModel.Stamina = totalStamina;
            //monsterTurnModel.
            return monsterTurnModel;
        }

        private async Task<BattleResultModel> EndBattleAsync(EndBattleModel model)
        {
            Battle battleBasic = await _unitOfWork.BattleRepository.GetByIdAsync(model.BattleId);
            battleBasic.TeamWinner = model.TeamWinner;
            battleBasic.EndDate = DateTime.Now;

            _unitOfWork.BattleRepository.Update(battleBasic);

            GetBattleByIdModel getBattleByIdModel = new GetBattleByIdModel
            {
                Id = battleBasic.BattleId,
                LanguageId = model.LanguageId
            };
            return await GetBattleById(getBattleByIdModel, string.Format("Team {0} is the winner", model.TeamWinner));
        }

        private async Task<BattleResultModel> GetBattleById(GetBattleByIdModel model, string message)
        {
            Battle battle = await _unitOfWork.BattleRepository.GetByIdAsync(model.Id, model.LanguageId);
            BattleResultModel battleResultModel = _mapper.Map<BattleResultModel>(battle);
            battleResultModel.ZoneResultModel = _mapper.Map<ZoneResultModel>(battle.Zone);

            battleResultModel.Participants = _mapper.Map<List<ParticipantResultModel>>(battle.BattleParticipants);
            IEnumerable<BattleAction> battleActions = await _unitOfWork.BattleActionRepository.GetAllByBattleId(battle.BattleId);
            battleResultModel.BattleActions = _mapper.Map<List<BattleActionModel>>(battleActions);

            battleResultModel.Message = message;

            return battleResultModel;
        }
    }
}
