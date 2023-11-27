using AutoMapper;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Result;
using MonsterSlayersAPI.BLL.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Services
{
    public class MonsterService : BaseService, IMonsterService
    {
        public MonsterService(IUnityOfWork unityOfWork, IMapper mapper, IBattleRepository battleRepository) : base(unityOfWork, battleRepository, mapper) { }

        public async Task<IEnumerable<MonsterResultModel>> GetMonstersByZoneId(GetMonstersByZoneIdModel model)
        {
            IEnumerable<Monster> monsters = await _unityOfWork.MonsterRepository.GetAllByZoneId(model.ZoneId, model.LanguageId);
            return _mapper.Map<IEnumerable<MonsterResultModel>>(monsters);
        }
    }
}
