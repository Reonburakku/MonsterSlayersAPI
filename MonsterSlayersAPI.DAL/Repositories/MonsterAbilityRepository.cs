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
    public class MonsterAbilityRepository : BaseRepository<MonsterAbility>, IMonsterAbilityRepository
    {
        public MonsterAbilityRepository(MonsterSlayersContext context, string source = "") : base(context, source) { }

        public async Task<IEnumerable<MonsterAbility>> GetAllByMonsterIdAsync(int monsterId, int languageId)
        {
            return await dbSet.Select(x => new MonsterAbility
            {
                MonsterId = x.MonsterId,
                Ability = new Ability
                {
                    AbilityId = x.Ability.AbilityId,
                    AbilityResources = x.Ability.AbilityResources.Where(ar => ar.LanguageId == languageId).ToArray(),
                    DamageDice = x.Ability.DamageDice,
                    DamageType = new DamageType
                    {
                        DamageTypeId = x.Ability.DamageTypeId,
                        DamageTypeResources = x.Ability.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray(),
                        Image = x.Ability.DamageType.Image
                    },
                    DamageTypeId = x.Ability.DamageTypeId,
                    Image = x.Ability.Image,
                    ManaCost = x.Ability.ManaCost,
                    Skill = new Skill
                    {
                        SkillId = x.Ability.Skill.SkillId,
                        SkillResources = x.Ability.Skill.SkillResources.Where(sr => sr.LanguageId == languageId).ToArray()
                    },
                    SkillId = x.Ability.SkillId,
                    StaminaCost = x.Ability.StaminaCost,
                    
                }
            }).Where(x => x.MonsterId == monsterId).ToArrayAsync();
        }
    }
}
