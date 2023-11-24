using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces;
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
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Services
{
    public class BattleService : BaseService, IBattleService
    {
        public BattleService(IUnityOfWork unityOfWork, IMapper mapper) : base(unityOfWork, mapper) { }


        public async Task<BattleResultModel> GetBattleByIdAsync(GetBattleByIdModel model)
        {
            Battle battle = await _unityOfWork.BattleRepository.GetByIdAsync(model.Id, model.LanguageId);
            BattleResultModel battleResultModel = _mapper.Map<BattleResultModel>(battle);
            battleResultModel.ZoneResultModel = _mapper.Map<ZoneResultModel>(battle.Zone);
            //List<int> creatureIds = battle.BattleParticipants.Select(x => x.CreatureId).ToList();
            //IEnumerable<Creature> creatures = await _unityOfWork.CreatureRepository.GetInfoByIdRange(creatureIds, model.LanguageId);
            Monster monster = new Monster();
            Character character = new Character();
            
            battleResultModel.Participants = _mapper.Map<List<ParticipantResultModel>>(battle.BattleParticipants);
            //foreach (ParticipantResultModel bp in battleResultModel.Participants)
            //{
            //    if (bp.IsMonster)
            //    {
            //        bp.Monster = JsonSerializer.Deserialize<MonsterBattleModel>(bp.ParticipantData);
            //    }
            //    else
            //    {
            //        bp.Character = JsonSerializer.Deserialize<CharacterBattleModel>(bp.ParticipantData);
            //    }
            //}

            return battleResultModel;
        }

        public async Task<IEnumerable<MonsterResultModel>> GetMonstersByZoneId(GetMonstersByZoneIdModel model)
        {
            IEnumerable<Monster> monsters = await _unityOfWork.MonsterRepository.GetAllByZoneId(model.ZoneId, model.LanguageId);
            return _mapper.Map<IEnumerable<MonsterResultModel>>(monsters);
        }

        public Task<bool> EndTurn(EndTurnModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetCharacterZoneId(SetCharacterZoneIdModel model)
        {
            try
            {
                Character character = await _unityOfWork.CharacterRepository.GetByIdAsync(model.CharacterId);
                if (character == null)
                {
                    return false;
                }
                character.ZoneId = model.ZoneId;
                character.ModifiedBy = model.Origin;
                character.ModifiedOn = DateTime.Now;
                await _unityOfWork.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<BattleResultModel> StartBattle(StartBattleModel model)
        {
            List<BattleParticipant> battleParticipants = new List<BattleParticipant>();

            Battle battle = _mapper.Map<Battle>(model);
            battle.CreatedBy = model.Origin;
            battle.CreatedOn = DateTime.Now;

            IEnumerable<Character> characters = await _unityOfWork.CharacterRepository.GetByIdRangeAsync(model.CharactersIds, model.LanguageId);
            if(characters.Count() < model.CharactersIds.Count())
            {
                return new BattleResultModel
                {
                    Message = "No hay personajes"
                };
            }
            IEnumerable<Monster> monsters = await _unityOfWork.MonsterRepository.GetByIdRangeAsync(model.MonstersIds, model.LanguageId);
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
                    CreatedBy = model.Origin,
                    CreatedOn = DateTime.Now,
                    Team = item.Item3,
                    CreatureId = item.Item1,
                    Order = ord,
                    IsMonster = item.Item4,
                    ParticipantData = GetSerializedParticipant(item.Item4, monsters.FirstOrDefault(x => x.CreatureId == item.Item1), characters.FirstOrDefault(x => x.CreatureId == item.Item1))
                });
                ord++;
            }

            battle.BattleParticipants = battleParticipants;

            battle = await _unityOfWork.BattleRepository.Save(battle);
            await _unityOfWork.CommitAsync();

            GetBattleByIdModel getBattleByIdModel = new GetBattleByIdModel
            {
                Id = battle.BattleId,
                LanguageId = model.LanguageId
            };
            return await GetBattleByIdAsync(getBattleByIdModel);
        }

        public async Task<AttackResultModel> UseAbility(UseAbilityModel model)
        {
            Battle battle = await _unityOfWork.BattleRepository.GetByIdAsync(model.BattleId, model.LanguageId);
            Ability ability = await _unityOfWork.AbilityRepository.GetByIdAsync(model.AbilityId, model.LanguageId);

            BattleParticipant sourceBattleParticipant = battle.BattleParticipants.First(x => x.CreatureId == model.SourceCharacterId);
            CharacterBattleModel sourceCreature = JsonSerializer.Deserialize<CharacterBattleModel>(sourceBattleParticipant.ParticipantData);

            BattleParticipant targetBattleParticipant = battle.BattleParticipants.First(x => x.CreatureId == model.TargetCreatureId);


            sourceCreature.Stamina -= ability.StaminaCost;
            sourceCreature.Mana -= ability.ManaCost;

            CharacterSkill characterSkill = await _unityOfWork.CharacterSkillRepository.GetByCharacterIdSkillIdAsync(sourceCreature.CharacterId, ability.SkillId, model.LanguageId);

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
            }
            else
            {
                CharacterBattleModel target = JsonSerializer.Deserialize<CharacterBattleModel>(targetBattleParticipant.ParticipantData);
                resistance = target.ResistanceBattleModels.First(x => x.DamageTypeId == ability.DamageTypeId).Resistance;
                realDamage = UtilityFunctions.AplyResistance(damage, resistance);
                target.HP = (int)(target.HP - realDamage);

                targetBattleParticipant.ParticipantData = JsonSerializer.Serialize(target);
            }

            sourceBattleParticipant.ParticipantData = JsonSerializer.Serialize(sourceBattleParticipant);


            BattleAction battleAction = new BattleAction
            {
                AbilityId = ability.AbilityId,
                BattleId = model.BattleId,
                Value = realDamage,
                BattleActionAffecteds = new List<BattleActionAffected>
                {
                    new BattleActionAffected
                    {
                        CreatureId = sourceCreature.CreatureId,
                        Type = "Source"
                    },
                    new BattleActionAffected
                    {
                        CreatureId = targetBattleParticipant.CreatureId,
                        Type = "Target"
                    }
                }
            };

            await _unityOfWork.BattleActionRepository.Save(battleAction);
            await _unityOfWork.CommitAsync();


            return new AttackResultModel
            {
                Message = "Success",
                NewManaPoints = sourceCreature.Mana,
                NewStaminaPoints = sourceCreature.Stamina
            };
        }

        private string GetSerializedParticipant(bool isMonster, Monster? monster, Character? character)
        {
            if(isMonster)
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
    }
}
