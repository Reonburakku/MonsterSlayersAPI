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
    public class CharacterSkillRepository : BaseRepository<CharacterSkill>, ICharacterSkillRepository
    {
        public CharacterSkillRepository(MonsterSlayersContext context, string source = "") : base(context, source) { }

        public async Task<IEnumerable<CharacterSkill>> GetAllByCharacterId(int characterSkillId, int languageId)
        {
            return await dbSet.Select(x => new CharacterSkill
            {
                CharacterId = x.CharacterId,
                SkillId = x.SkillId,
                Skill = new Skill
                {
                    SkillId = x.SkillId,
                    SkillResources = x.Skill.SkillResources.Where(sr => sr.LanguageId == languageId).ToArray()
                },
                Total = x.Total,
                Real = x.Real
            }).Where(x => x.CharacterId == characterSkillId).ToArrayAsync();
        }

        public async ValueTask<CharacterSkill> GetByCharacterIdSkillIdAsync(int characterSkillId, int skillId, int languageId)
        {

            return await dbSet.Select(x => new CharacterSkill
            {
                CharacterId = x.CharacterId,
                SkillId = x.SkillId,
                Skill = new Skill
                {
                    SkillId = x.SkillId,
                    SkillResources = x.Skill.SkillResources.Where(sr => sr.LanguageId == languageId).ToArray()
                },
                Total = x.Total,
                Real = x.Real
            }).FirstAsync(x => x.CharacterId == characterSkillId && x.SkillId == skillId);
        }
    }
}
