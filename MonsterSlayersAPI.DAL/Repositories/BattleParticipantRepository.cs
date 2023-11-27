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
    public class BattleParticipantRepository : BaseRepository<BattleParticipant>, IBattleParticipantRepository
    {
        public BattleParticipantRepository(MonsterSlayersContext context, string source = "") : base(context, source) { }

        public async Task<IEnumerable<BattleParticipant>> GetAllByBattleId(int battleId)
        {
            return await dbSet.Where(x => x.BattleId == battleId).ToArrayAsync();
        }
    }
}
