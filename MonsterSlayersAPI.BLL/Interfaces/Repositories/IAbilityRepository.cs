using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface IAbilityRepository : IBaseRepository<Ability>
    {
        Task<IEnumerable<Ability>> GetAllByClassIdAsync(int classId, int languageId);
        Task<IEnumerable<Ability>> GetAllByCharacterIdAsync(int characterId, int languageId);
        Task<IEnumerable<Ability>> GetAllByMonsterIdAsync(int monsterId, int languageId);
        ValueTask<Ability> GetByIdAsync(int id, int languageId);
    }
}
