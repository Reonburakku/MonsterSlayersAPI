using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface IMonsterRepository : IBaseRepository<Monster>
    {
        Task<IEnumerable<Monster>> GetAllByZoneId(int zoneId, int languageId);
        Task<IEnumerable<Monster>> GetByIdRangeAsync(IEnumerable<int> monsterIds, int languageId);
        Task<Monster> GetFullById(int monsterId, int languageId);
        Task<IEnumerable<Monster>> GetInfoByIdRange(IEnumerable<int> monsterIds, int languageId);
    }
}
