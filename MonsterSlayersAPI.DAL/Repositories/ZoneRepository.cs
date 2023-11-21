using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.DAL.Repositories.Base;
using MonsterSlayersAPI.Security.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.DAL.Repositories
{
    public class ZoneRepository : BaseRepository<Zone>, IZoneRepository
    {

        public ZoneRepository(MonsterSlayersContext context) : base(context) { }

        public async Task<IEnumerable<Zone>> GetAllAsync(int languageId)
        {
            return await dbSet.Select(x => new Zone
            {
                Name = x.Name,
                ZoneResources = x.ZoneResources.Where(r => r.LanguageId == languageId).ToArray(),
                ZoneId = x.ZoneId
            }).ToArrayAsync();
        }
        public async ValueTask<Zone> GetByIdAsync(int id, int languageId)
        {
            return await dbSet.Select(x => new Zone
            {
                Name = x.Name,
                ZoneResources = x.ZoneResources.Where(r => r.LanguageId == languageId).ToArray(),
                ZoneId = x.ZoneId
            }).FirstAsync(x => x.ZoneId == id);
        }
    }
}
