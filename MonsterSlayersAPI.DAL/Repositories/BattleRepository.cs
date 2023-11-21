using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities;
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
    public class BattleRepository : BaseRepository<Battle>, IBattleRepository
    {
        public BattleRepository(MonsterSlayersContext context) : base(context) { }

        public async ValueTask<Battle> GetByIdAsync(int id, int languageId)
        {
            return await dbSet.Select(x => new Battle
            {
                BattleId = x.BattleId,
                BattleActions = x.BattleActions,
                BattleParticipants = x.BattleParticipants,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Zone = x.Zone
            }).Where(x => x.BattleId == id).FirstAsync();
    }
}
}
