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
        public CharacterRepository(MonsterSlayersContext context) : base(context) { }

        public async Task<IEnumerable<Character>> GetByIdRangeAsync(IEnumerable<int> CharacterIds)
        {

            return await dbSet.Where(x => CharacterIds.Contains(x.CharacterId)).ToArrayAsync();
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
                        DamageTypeResources = cr.DamageType.DamageTypeResources.Where(dtr => dtr.LanguageId == languageId).ToArray(),
                        Name = cr.DamageType.Name
                    },
                    DamageTypeId = cr.DamageTypeId,
                    Value = cr.Value,
                }).ToArray(),
                Class = new Class
                {
                    ClassId = c.ClassId,
                    ClassResources = c.Class.ClassResources.Where(cr => cr.LanguageId == languageId).ToArray(),
                    DexterityRate = c.Class.DexterityRate,
                    FaithhRate = c.Class.FaithhRate,
                    HPRate = c.Class.HPRate,
                    IntelligenceRate = c.Class.IntelligenceRate,
                    Logo = c.Class.Logo,
                    Name = c.Class.Name,
                    StrengthRate = c.Class.StrengthRate
                },
                ClassId = c.ClassId,
                CharacterSkills = c.CharacterSkills.Select(cs => new CharacterSkill
                {
                    SkillId = cs.SkillId,
                    Skill = new Skill
                    {
                        Name = cs.Skill.Name,
                        DamageDice = cs.Skill.DamageDice,
                        DamageType = cs.Skill.DamageType,
                        DamageTypeId = cs.Skill.DamageTypeId,
                        Image = cs.Skill.Image,
                        ManaCost = cs.Skill.ManaCost,
                        SkillId = cs.Skill.SkillId,
                        SkillResources = cs.Skill.SkillResources.Where(sr => sr.LanguageId == languageId).ToArray()
                    }
                }).ToArray(),
                CreatureId = c.ClassId,
                CritDamage = c.CritDamage,
                CritRate = c.CritRate,
                CurrentHP = c.CurrentHP,
                Dexterity = c.Dexterity,
                DexterityPoints = c.DexterityPoints,
                Experience = c.Experience,
                Faith = c.Faith,
                FaithPoints = c.FaithPoints,
                HP = c.HP,
                Image = c.Image,
                Intelligence = c.Intelligence,
                IntelligencePoints = c.IntelligencePoints,
                Mana = c.Mana,
                Name = c.Name,
                Nivel = c.Nivel,
                Speed = c.Speed,
                Stamina = c.Stamina,
                Strength = c.Strength,
                StrengthPoints = c.StrengthPoints,
                Vitality = c.Vitality,
                VitalityPoints = c.VitalityPoints,
                Zone = new Zone
                {
                    Name = c.Zone.Name,
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
                CharacterSkills = c.CharacterSkills,
                CreatureId = c.ClassId,
                CritDamage = c.CritDamage,
                CritRate = c.CritRate,
                CurrentHP = c.CurrentHP,
                Dexterity = c.Dexterity,
                DexterityPoints = c.DexterityPoints,
                Experience = c.Experience,
                Faith = c.Faith,
                FaithPoints = c.FaithPoints,
                HP = c.HP,
                Image = c.Image,
                Intelligence = c.Intelligence,
                IntelligencePoints = c.IntelligencePoints,
                Mana = c.Mana,
                Name = c.Name,
                Nivel = c.Nivel,
                Speed = c.Speed,
                Stamina = c.Stamina,
                Strength = c.Strength,
                StrengthPoints = c.StrengthPoints,
                Vitality = c.Vitality,
                VitalityPoints = c.VitalityPoints,
                Zone = c.Zone,
                ZoneId = c.ZoneId
            }).Where(c => CharacterIds.Contains(c.CharacterId)).ToArrayAsync();
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
