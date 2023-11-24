using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface ICharacterSkillRepository : IBaseRepository<CharacterSkill>
    {
        ValueTask<CharacterSkill> GetByCharacterIdSkillIdAsync(int characterSkillId, int skillId, int languageId);
        Task<IEnumerable<CharacterSkill>> GetAllByCharacterId(int characterSkillId, int languageId);
    }
}
