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
    public class BattleRepository : BaseRepository<Battle>, IBattleRepository
    {
        public BattleRepository(MonsterSlayersContext context) : base(context) { }

        public async ValueTask<Battle> GetByIdAsync(int id, int languageId)
        {
            return await dbSet.Select(x => new Battle
            {
                BattleId = x.BattleId,
                BattleActions = x.BattleActions.Select(ba => new BattleAction
                {
                    BattleActionId = ba.BattleActionId,
                    BattleActionAffecteds = ba.BattleActionAffecteds,
                    Skill = new Skill
                    {
                        SkillId = ba.Skill.SkillId,
                        SkillResources = ba.Skill.SkillResources.Where(sr => sr.LanguageId == languageId).ToArray(),
                    },
                    Value = ba.Value
                }).ToArray(),
                BattleParticipants = x.BattleParticipants.Select(x => new BattleParticipant
                {
                    CreatureId = x.CreatureId,
                    Creature = new Creature
                    {
                        CreatureId = x.Creature.CreatureId,
                        Characters = x.Creature.Characters.Select(c => new Character
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
                        }).ToArray(),
                        Monsters = x.Creature.Monsters.Select(x => new Monster
                        {
                            MonsterId = x.MonsterId,
                            CreatureId = x.CreatureId,
                            HP = x.HP,
                            Image = x.Image,
                            Mana = x.Mana,
                            MonsterResources = x.MonsterResources.Where(mr => mr.LanguageId == languageId).ToArray(),
                            Nivel = x.Nivel,
                            Speed = x.Speed,
                            Stamina = x.Stamina,
                            MonsterZones = x.MonsterZones
                        }).ToArray()
                    }
                }).ToArray(),
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Zone = new Zone
                {
                    ZoneId = x.Zone.ZoneId,
                    ZoneResources = x.Zone.ZoneResources.Where(zr => zr.LanguageId == languageId).ToArray()
                }
            }).Where(x => x.BattleId == id).FirstAsync();
    }
}
}
