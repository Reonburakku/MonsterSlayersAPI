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
    public class BattleActionRepository : BaseRepository<BattleAction>, IBattleActionRepository
    {
        public BattleActionRepository(MonsterSlayersContext context, string source = "") : base(context, source) { }

        public async Task<IEnumerable<BattleAction>> GetAllByBattleId(int battleId)
        {
            return await dbSet.Where(x =>  x.BattleId == battleId).ToArrayAsync();
        }
    }
}
