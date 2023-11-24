using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface ISkillRepository : IBaseRepository<Skill>
    {
        ValueTask<Skill> GetByIdAsync(int skillId, int languageId);
        Task<IEnumerable<Skill>> GetByCharacterIdAsync(int characterId, int languageId);
    }
}
