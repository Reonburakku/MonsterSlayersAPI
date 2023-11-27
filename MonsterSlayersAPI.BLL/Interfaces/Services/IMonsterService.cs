using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Services
{
    public interface IMonsterService
    {
        Task<IEnumerable<MonsterResultModel>> GetMonstersByZoneId(GetMonstersByZoneIdModel model);
    }
}
