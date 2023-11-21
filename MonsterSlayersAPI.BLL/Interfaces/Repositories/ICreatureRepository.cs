using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface ICreatureRepository : IBaseRepository<Creature>
    {
        Task<Creature> GetInfoById(int creatureid, int languageId);
        Task<IEnumerable<Creature>> GetInfoByIdRange(List<int> creatureids, int languageId);
    }
}
