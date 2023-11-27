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
using System.Transactions;

namespace MonsterSlayersAPI.DAL.Repositories
{
    public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(MonsterSlayersContext context, string source = "") : base(context, source) { }

        public async Task<IEnumerable<Character>> GetByIdRangeAsync(IEnumerable<int> CharacterIds, int languageId)
        {

            return await dbSet.Select(c => new Character
            {
                CharacterId = c.CharacterId,
                CharacterResistances = c.CharacterResistances.Select(cr => new CharacterResistance
                {
                    CharacterId = cr.CharacterId,
                    DamageType = new DamageType
                    {
                        DamageTypeId = cr.DamageTypeId,
                        Image = cr.DamageType.Image,
                        DamageTypeResources = cr.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray()
                    },
                    DamageTypeId = cr.DamageTypeId,
                    Value = cr.Value,
                }).ToArray(),
                Class = c.Class,
                ClassId = c.ClassId,
                CharacterAbilitys = c.CharacterAbilitys,
                CreatureId = c.CreatureId,
                CritDamage = c.CritDamage,
                CritRate = c.CritRate,
                Experience = c.Experience,
                HP = c.HP,
                Image = c.Image,
                Mana = c.Mana,
                Name = c.Name,
                Nivel = c.Nivel,
                CharacterSkills = c.CharacterSkills.Select(cs => new CharacterSkill
                {
                    CharacterId = cs.CharacterId,
                    SkillId = cs.SkillId,
                    Total = cs.Total,
                    Real = cs.Real,
                    Skill = new Skill
                    {
                        SkillId = cs.SkillId,
                        SkillResources = cs.Skill.SkillResources.Where(sr => sr.LanguageId == languageId).ToArray()
                    }
                }).ToArray(),
                Speed = c.Speed,
                Stamina = c.Stamina,
                Zone = c.Zone,
                ZoneId = c.ZoneId
            }).Where(x => CharacterIds.Contains(x.CharacterId)).ToArrayAsync();
        }

        public async Task<Character> GetFullById(int characterId, int languageId)
        {
            return await dbSet.Select(c => new Character
            {
                CharacterId = c.CharacterId,
                CharacterResistances = c.CharacterResistances.Select(cr => new CharacterResistance
                {
                    CharacterId = cr.CharacterId,
                    DamageType = new DamageType
                    {
                        DamageTypeId = cr.DamageTypeId,
                        Image = cr.DamageType.Image,
                        DamageTypeResources = cr.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray()
                    },
                    DamageTypeId = cr.DamageTypeId,
                    Value = cr.Value,
                }).ToArray(),
                Class = new Class
                {
                    ClassId = c.ClassId,
                    ClassResources = c.Class.ClassResources.Where(cr => cr.LanguageId == languageId).ToArray(),
                    ForPlayer = c.Class.ForPlayer,
                    Image = c.Image
                },
                ClassId = c.ClassId,
                CharacterAbilitys = c.CharacterAbilitys.Select(ch => new CharacterAbility
                {
                    AbilityId = ch.AbilityId,
                    Ability = new Ability
                    {
                        DamageDice = ch.Ability.DamageDice,
                        DamageType = ch.Ability.DamageType,
                        DamageTypeId = ch.Ability.DamageTypeId,
                        Image = ch.Ability.Image,
                        ManaCost = ch.Ability.ManaCost,
                        AbilityId = ch.Ability.AbilityId,
                        AbilityResources = ch.Ability.AbilityResources.Where(hr => hr.LanguageId == languageId).ToArray()
                    }
                }).ToArray(),
                CreatureId = c.CreatureId,
                CritDamage = c.CritDamage,
                CritRate = c.CritRate,
                Experience = c.Experience,
                HP = c.HP,
                Image = c.Image,
                Mana = c.Mana,
                Name = c.Name,
                Nivel = c.Nivel,
                CharacterSkills = c.CharacterSkills.Select(cs => new CharacterSkill
                {
                    CharacterId = cs.CharacterId,
                    SkillId = cs.SkillId,
                    Total = cs.Total,
                    Real = cs.Real,
                    Skill = new Skill
                    {
                        SkillId = cs.SkillId,
                        SkillResources = cs.Skill.SkillResources.Where(sr => sr.LanguageId == languageId).ToArray()
                    }
                }).ToArray(),
                Speed = c.Speed,
                Stamina = c.Stamina,
                Zone = new Zone
                {
                    Image = c.Image,
                    ZoneId = c.ZoneId,
                    ZoneResources = c.Zone.ZoneResources.Where(zr => zr.LanguageId == languageId).ToArray()
                },
                ZoneId = c.ZoneId
            }).Where(c => c.CharacterId == characterId).FirstAsync();
        }

        public async Task<IEnumerable<Character>> GetInfoByIdRange(IEnumerable<int> CharacterIds, int languageId)
        {
            return await dbSet.Select(c => new Character
            {
                CharacterId = c.CharacterId,
                CharacterResistances = c.CharacterResistances,
                Class = c.Class,
                ClassId = c.ClassId,
                CharacterAbilitys = c.CharacterAbilitys,
                CreatureId = c.CreatureId,
                CritDamage = c.CritDamage,
                CritRate = c.CritRate,
                Experience = c.Experience,
                HP = c.HP,
                Image = c.Image,
                Mana = c.Mana,
                Name = c.Name,
                Nivel = c.Nivel,
                Speed = c.Speed,
                Stamina = c.Stamina,
                Zone = c.Zone,
                ZoneId = c.ZoneId
            }).Where(c => CharacterIds.Contains(c.CharacterId)).ToArrayAsync();
        }

        public async Task<IEnumerable<CharacterSkill>> GetSkillsByCharacterId(int characterId, int languageId) 
        {
            return dbSet.First(x => x.CharacterId == characterId).CharacterSkills.Select(x => new CharacterSkill
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
            });
        }

        public async Task<Character> UpdateZone(int CharacterId, int zoneId)
        {
            Character character = await dbSet.FindAsync(CharacterId);
            if (character == null)
            {
                return null;
            }
            character.ZoneId = zoneId;
            context.SaveChanges();
            return character;
        }
    }
}
