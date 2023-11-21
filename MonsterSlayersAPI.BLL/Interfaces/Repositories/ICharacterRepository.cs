using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface ICharacterRepository : IBaseRepository<Character>
    {
        Task<IEnumerable<Character>> GetByIdRangeAsync(IEnumerable<int> CharacterIds);
        Task<Character> GetFullById(int characterId, int languageId);
        Task<IEnumerable<Character>> GetInfoByIdRange(IEnumerable<int> CharacterIds, int languageId);
        Task<Character> UpdateZone(int CharacterId, int zoneId);
    }
}
