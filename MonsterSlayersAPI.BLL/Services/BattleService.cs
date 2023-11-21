using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models;
using MonsterSlayersAPI.BLL.Models.Request.Base;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            List<int> creatureIds = battle.BattleParticipants.Select(x => x.CreatureId).ToList();
            IEnumerable<Creature> creatures = await _unityOfWork.CreatureRepository.GetInfoByIdRange(creatureIds, model.LanguageId);
            battleResultModel.Participants = _mapper.Map<List<ParticipantResultModel>>(battle.BattleParticipants);

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

            IEnumerable<Character> characters = await _unityOfWork.CharacterRepository.GetByIdRangeAsync(model.CharactersIds);
            if(characters.Count() < model.CharactersIds.Count())
            {
                return new BattleResultModel
                {
                    Message = "No hay personajes"
                };
            }
            IEnumerable<Monster> monsters = await _unityOfWork.MonsterRepository.GetByIdRangeAsync(model.MonstersIds);
            if (monsters.Count() < model.MonstersIds.Count())
            {
                return new BattleResultModel
                {
                    Message = "No hay monstruos"
                };
            }

            List<Tuple<int, int, string>> creatures = new List<Tuple<int, int, string>>();
            foreach (var character in characters)
            {
                creatures.Add(new Tuple<int, int, string>(character.CreatureId, character.Speed, "A"));
            }
            foreach (var monster in monsters)
            {
                creatures.Add(new Tuple<int, int, string>(monster.CreatureId, monster.Speed, "B"));
            }
            creatures.OrderByDescending(x => x.Item2);
            int ord = 1;
            foreach (Tuple<int, int, string> item in creatures)
            {
                battleParticipants.Add(new BattleParticipant
                {
                    CreatedBy = model.Origin,
                    CreatedOn = DateTime.Now,
                    Team = item.Item3,
                    CreatureId = item.Item1,
                    Order = ord,
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

        public Task<AttackResultModel> UseHability(UseHabilityModel model)
        {
            throw new NotImplementedException();
        }
    }
}
