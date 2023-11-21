using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Services
{
    public interface IBattleService
    {
        Task<BattleResultModel> GetBattleByIdAsync(GetBattleByIdModel model);
        Task<IEnumerable<MonsterResultModel>> GetMonstersByZoneId(GetMonstersByZoneIdModel model);
        Task<bool> SetCharacterZoneId(SetCharacterZoneIdModel model);
        Task<BattleResultModel> StartBattle(StartBattleModel model);
        Task<AttackResultModel> UseHability(UseHabilityModel model);
        Task<bool> EndTurn(EndTurnModel model);

    }
}
