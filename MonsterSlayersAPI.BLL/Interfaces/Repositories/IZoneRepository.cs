using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface IZoneRepository : IBaseRepository<Zone>
    {
        Task<IEnumerable<Zone>> GetAllAsync(int languageId);
        ValueTask<Zone> GetByIdAsync(int id, int languageId);
    }
}
