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
    public class AbilityRepository : BaseRepository<Ability>, IAbilityRepository
    {
        public AbilityRepository(MonsterSlayersContext context) : base(context) { }

        public async Task<IEnumerable<Ability>> GetAllByCharacterIdAsync(int characterId, int languageId)
        {
            return await dbSet.Select(x => new Ability
            {
                DamageDice = x.DamageDice,
                DamageType = new DamageType
                {
                    DamageTypeId = x.DamageType.DamageTypeId,
                    DamageTypeResources = x.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray(),
                    Image = x.DamageType.Image
                },
                DamageTypeId = x.DamageTypeId,
                Image = x.Image,
                ManaCost = x.ManaCost,
                AbilityResources = x.AbilityResources.Where(sr => sr.LanguageId == languageId).ToArray()
            }).Where(x => x.CharacterAbilitys.Any(cs => cs.CharacterId == characterId)).ToArrayAsync();
        }

        public async Task<IEnumerable<Ability>> GetAllByMonsterIdAsync(int monsterId, int languageId)
        {
            return await dbSet.Select(x => new Ability
            {
                DamageDice = x.DamageDice,
                DamageType = new DamageType
                {
                    DamageTypeId = x.DamageType.DamageTypeId,
                    DamageTypeResources = x.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray(),
                    Image = x.DamageType.Image
                },
                DamageTypeId = x.DamageTypeId,
                Image = x.Image,
                ManaCost = x.ManaCost,
                AbilityResources = x.AbilityResources.Where(sr => sr.LanguageId == languageId).ToArray()
            }).Where(x => x.MonsterAbilitys.Any(ms => ms.MonsterId == monsterId)).ToArrayAsync();
        }

        public async Task<IEnumerable<Ability>> GetAllByClassIdAsync(int classId, int languageId)
        {
            return await dbSet.Select(x => new Ability
            {
                DamageDice = x.DamageDice,
                DamageType = new DamageType
                {
                    DamageTypeId = x.DamageType.DamageTypeId,
                    DamageTypeResources = x.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray(),
                    Image = x.DamageType.Image
                },
                DamageTypeId = x.DamageTypeId,
                Image = x.Image,
                ManaCost = x.ManaCost,
                AbilityResources = x.AbilityResources.Where(sr => sr.LanguageId == languageId).ToArray()
            }).Where(x => x.ClassAbilitys.Any(cs => cs.ClassId == classId)).ToArrayAsync();
        }

        public async ValueTask<Ability> GetByIdAsync(int id, int languageId)
        {
            return await dbSet.Select(x => new Ability
            {
                AbilityId = x.AbilityId,
                Name = x.Name,
                SkillId = x.SkillId,
                DamageDice = x.DamageDice,
                DamageType = new DamageType
                {
                    DamageTypeId = x.DamageType.DamageTypeId,
                    DamageTypeResources = x.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray(),
                    Image = x.DamageType.Image
                },
                DamageTypeId = x.DamageTypeId,
                Image = x.Image,
                ManaCost = x.ManaCost,
                StaminaCost = x.StaminaCost,
                AbilityResources = x.AbilityResources.Where(sr => sr.LanguageId == languageId).ToArray()
            }).FirstAsync(x => x.AbilityId == id);
            //return await dbSet.FirstAsync(x => x.AbilityId == id);
        }
    }
}
