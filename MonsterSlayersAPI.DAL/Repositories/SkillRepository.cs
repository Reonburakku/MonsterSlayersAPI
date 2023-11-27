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
    public class SkillRepository : BaseRepository<Skill>, ISkillRepository
    {
        public SkillRepository(MonsterSlayersContext context, string source = "") : base(context, source) { }

        public async Task<IEnumerable<Skill>> GetByCharacterIdAsync(int characterId, int languageId)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Skill> GetByIdAsync(int skillId, int languageId)
        {
            throw new NotImplementedException();
        }
    }
}
