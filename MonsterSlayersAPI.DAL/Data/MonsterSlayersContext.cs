using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MonsterSlayersAPI.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Security.DAL.Data
{
    public class MonsterSlayersContext : DbContext
    {
        public MonsterSlayersContext(DbContextOptions<MonsterSlayersContext> options) : base(options)
        {
        }


        DbSet<Battle> Battles { get; set; }
        DbSet<BattleAction> BattleActions { get; set; }
        DbSet<BattleActionAffected> BattleActionAffecteds { get; set; }
        DbSet<BattleParticipant> BattleParticipants { get; set; }
        DbSet<Character> Characters { get; set; }
        DbSet<CharacterResistance> CharacterResistances { get; set; }
        DbSet<CharacterSkill> CharacterSkills { get; set; }
        DbSet<Class> Classes { get; set; }
        DbSet<ClassResource> ClassResources { get; set; }
        DbSet<ClassSkill> ClassSkills { get; set; }
        DbSet<Creature> Creatures { get; set; }
        DbSet<DamageType> DamageTypes { get; set; }
        DbSet<DamageTypeResource> DamageTypeResources { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<MessageResource> MessageResources { get; set; }
        DbSet<Monster> Monsters { get; set; }
        DbSet<MonsterResistance> MonsterResistances { get; set; }
        DbSet<MonsterResource> MonsterResources { get; set; }
        DbSet<MonsterSkill> MonsterSkills { get; set; }
        DbSet<MonsterZone> MonsterZones { get; set; }
        DbSet<ResourceType> ResourceTypes { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<SkillResource> SkillResources { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Zone> Zones { get; set; }
        DbSet<ZoneResource> ZoneResources { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Battle>().ToTable("Battle");
            builder.Entity<BattleAction>().ToTable("BattleAction");
            builder.Entity<BattleActionAffected>().ToTable("BattleActionAffected");
            builder.Entity<BattleParticipant>().ToTable("BattleParticipant");
            builder.Entity<Character>().ToTable("Character");
            builder.Entity<CharacterResistance>().ToTable("CharacterResistance");
            builder.Entity<CharacterSkill>().ToTable("CharacterSkill");
            builder.Entity<Class>().ToTable("Class");
            builder.Entity<ClassResource>().ToTable("ClassResource");
            builder.Entity<ClassSkill>().ToTable("ClassSkill");
            builder.Entity<Creature>().ToTable("Creature");
            builder.Entity<DamageType>().ToTable("DamageType");
            builder.Entity<DamageTypeResource>().ToTable("DamageTypeResource");
            builder.Entity<Language>().ToTable("Language");
            builder.Entity<MessageResource>().ToTable("MessageResource");
            builder.Entity<Monster>().ToTable("Monster");
            builder.Entity<MonsterResource>().ToTable("MonsterResource");
            builder.Entity<MonsterResistance>().ToTable("MonsterResistance");
            builder.Entity<MonsterSkill>().ToTable("MonsterSkill");
            builder.Entity<MonsterZone>().ToTable("MonsterZone");
            builder.Entity<ResourceType>().ToTable("ResourceType");
            builder.Entity<Skill>().ToTable("Skill");
            builder.Entity<SkillResource>().ToTable("SkillResource");
            builder.Entity<User>().ToTable("User");
            builder.Entity<Zone>().ToTable("Zone");
            builder.Entity<ZoneResource>().ToTable("ZoneResource");
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("GAME");
            builder.UseIdentityColumns();
            SeedUser(builder);
            SeedCreature(builder);
            SeedCharacter(builder);
            SeedLanguage(builder);
            SeedResourceType(builder);
            SeedDamageType(builder);
            SeedDamageTypeResource(builder);
            SeedClass(builder);
            SeedClassResource(builder);
            SeedZone(builder);
            SeedZoneResource(builder);
            SeedMessageResource(builder);
            SeedMonster(builder);
            SeedMonsterResource(builder);
            SeedMonsterResistance(builder);
            SeedMonsterZone(builder);
            SeedSkill(builder);
            SeedSkillResource(builder);
            SeedMonsterSkill(builder);
        }
        private void SeedUser(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new User()
            {
                UserId = 1,
                Name = "Snorlax",
                ASPUserId = "",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now

            });
        }
        private void SeedCreature(ModelBuilder builder)
        {
            builder.Entity<Creature>().HasData(new Creature()
            {
                CreatureId = 1,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Creature>().HasData(new Creature()
            {
                CreatureId = 2,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Creature>().HasData(new Creature()
            {
                CreatureId = 3,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Creature>().HasData(new Creature()
            {
                CreatureId = 4,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedCharacter(ModelBuilder builder)
        {
            builder.Entity<Character>().HasData(new Character()
            {
                CharacterId = 1,
                UserId = 1,
                ClassId = 1,
                CreatureId = 2,
                ZoneId = 1,
                Name = "Reonburakku",
                Nivel = 1,
                Experience = 0,
                Image = "ImageR",
                StrengthPoints = 1,
                DexterityPoints = 1,
                VitalityPoints = 1,
                IntelligencePoints = 1,
                FaithPoints = 1,
                Strength = 1,
                Dexterity = 1,
                Vitality = 1,
                Intelligence = 1,
                Faith = 1,
                HP = 10,
                Speed = 20,
                CritRate = 2,
                CritDamage = 2,
                Stamina = 6,
                Mana = 10,
                CurrentHP = 10,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now

            });
        }
        private void SeedLanguage(ModelBuilder builder)
        {
            builder.Entity<Language>().HasData(new Language()
            {
                LanguageId = 1,
                Name = "Español",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Language>().HasData(new Language()
            {
                LanguageId = 2,
                Name = "English",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedResourceType(ModelBuilder builder)
        {
            builder.Entity<ResourceType>().HasData(new ResourceType()
            {
                ResourceTypeId = 1,
                Value = "Name",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ResourceType>().HasData(new ResourceType()
            {
                ResourceTypeId = 2,
                Value = "Description",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedDamageType(ModelBuilder builder)
        {
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 1,
                Name = "Lightning",
                Image = "LightningLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 2,
                Name = "Fire",
                Image = "FireLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 3,
                Name = "Water",
                Image = "WaterLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 4,
                Name = "Wind",
                Image = "WindLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 5,
                Name = "Earth",
                Image = "EarthLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 6,
                Name = "Radiant",
                Image = "RadiantLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 7,
                Name = "Neutral",
                Image = "NeutralLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageType>().HasData(new DamageType()
            {
                DamageTypeId = 8,
                Name = "Acid",
                Image = "AcidLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedDamageTypeResource(ModelBuilder builder)
        {
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 1,
                Value = "Rayo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 2,
                Value = "Fuego",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 3,
                Value = "Agua",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 4,
                Value = "Aire",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 5,
                Value = "Tierra",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 6,
                Value = "Radiante",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 7,
                Value = "Neutro",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                DamageTypeId = 8,
                Value = "Ácido",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 1,
                Value = "Lightning",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 2,
                Value = "Fire",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 3,
                Value = "Water",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 4,
                Value = "Wind",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 5,
                Value = "Earth",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 6,
                Value = "Radiant",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 7,
                Value = "Neutral",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<DamageTypeResource>().HasData(new DamageTypeResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                DamageTypeId = 8,
                Value = "Acid",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedClass(ModelBuilder builder)
        {
            builder.Entity<Class>().HasData(new Class()
            {
                ClassId = 1,
                Name = "Monster",
                DexterityRate = 1.0,
                FaithhRate = 1.0,
                HPRate = 1.0,
                IntelligenceRate = 1.0,
                StrengthRate = 1.0,
                ForPlayer = false,
                Logo = "MonsterLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Class>().HasData(new Class()
            {
                ClassId = 2,
                Name = "Mage",
                DexterityRate = 1.0,
                FaithhRate = 1.0,
                HPRate = 1.0,
                IntelligenceRate = 1.0,
                StrengthRate = 1.0,
                ForPlayer = true,
                Logo = "MageLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Class>().HasData(new Class()
            {
                ClassId = 3,
                Name = "Warrior",
                DexterityRate = 1.0,
                FaithhRate = 1.0,
                HPRate = 1.0,
                IntelligenceRate = 1.0,
                StrengthRate = 1.0,
                ForPlayer = true,
                Logo = "WarriorLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Class>().HasData(new Class()
            {
                ClassId = 4,
                Name = "Cleric",
                DexterityRate = 1.0,
                FaithhRate = 1.0,
                HPRate = 1.0,
                IntelligenceRate = 1.0,
                StrengthRate = 1.0,
                ForPlayer = true,
                Logo = "ClericLogo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedClassResource(ModelBuilder builder)
        {
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                ClassId = 1,
                Value = "Monstruo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                ClassId = 2,
                Value = "Mago",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                ClassId = 3,
                Value = "Guerrero",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                ClassId = 4,
                Value = "Clérigo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 2,
                ClassId = 1,
                Value = "Criatura que habita el mundo y gusta de deborar humanos.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 2,
                ClassId = 2,
                Value = "Estudiante de las artes arcanas, capaz de crear grandes daños elementales.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 2,
                ClassId = 3,
                Value = "Luchador entrenado para la batalla, fuerte y resistente.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 1,
                ResourceTypeId = 2,
                ClassId = 4,
                Value = "Para muchos, enviado de los dioses, especialistas en curar y mejorar humanos.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                ClassId = 1,
                Value = "Monster",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                ClassId = 2,
                Value = "Wizard",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                ClassId = 3,
                Value = "Warrior",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                ClassId = 4,
                Value = "Cleric",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 2,
                ClassId = 1,
                Value = "Creature that inhabits the world and likes to devour humans.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 2,
                ClassId = 2,
                Value = "Student of the arcane arts, capable of creating great elemental damage.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 2,
                ClassId = 3,
                Value = "Fighter trained for battle, strong and resistant.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ClassResource>().HasData(new ClassResource()
            {
                LanguageId = 2,
                ResourceTypeId = 2,
                ClassId = 4,
                Value = "For many, sent from the gods, specialists in healing and improving humans.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedZone(ModelBuilder builder)
        {
            builder.Entity<Zone>().HasData(new Zone()
            {
                ZoneId = 1,
                Name = "City",
                Image = "CityBackGround",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Zone>().HasData(new Zone()
            {
                ZoneId = 2,
                Name = "Field",
                Image = "FieldBackGround",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedZoneResource(ModelBuilder builder)
        {
            builder.Entity<ZoneResource>().HasData(new ZoneResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                ZoneId = 1,
                Value = "Ciudad",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ZoneResource>().HasData(new ZoneResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                ZoneId = 2,
                Value = "Pradera",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ZoneResource>().HasData(new ZoneResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                ZoneId = 1,
                Value = "City",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<ZoneResource>().HasData(new ZoneResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                ZoneId = 2,
                Value = "Field",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedMessageResource(ModelBuilder builder)
        {
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 1,
                MessageName = "AttackSuccess",
                Value = "{target} recibe {damage} puntos de daño de {damagetype}.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 1,
                MessageName = "AttackFail",
                Value = "Ataque fallido.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 1,
                MessageName = "Heal",
                Value = "{target} recibe {heal} puntos de curación.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 1,
                MessageName = "NotYourTurn",
                Value = "No es tu turno.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 1,
                MessageName = "Win",
                Value = "Has ganado.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 1,
                MessageName = "Loose",
                Value = "Has perdido.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 2,
                MessageName = "AttackSuccess",
                Value = "{target} got {damage} {damagetype} damage proints.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 2,
                MessageName = "AttackFail",
                Value = "Atack failed.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 2,
                MessageName = "Heal",
                Value = "{target} got {heal} healing points.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 2,
                MessageName = "NotYourTurn",
                Value = "Is not your turn.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 2,
                MessageName = "Win",
                Value = "You win.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MessageResource>().HasData(new MessageResource()
            {
                LanguageId = 2,
                MessageName = "Loose",
                Value = "You Loose.",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedMonster(ModelBuilder builder)
        {
            builder.Entity<Monster>().HasData(new Monster()
            {
                MonsterId = 1,
                CreatureId = 1,
                Name = "Black Dragon",
                HP = 500,
                Image = "",
                Mana = 50,
                Nivel = 50,
                Stamina = 10,
                Speed = 50,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Monster>().HasData(new Monster()
            {
                MonsterId = 2,
                CreatureId = 3,
                Name = "Slime",
                HP = 10,
                Image = "",
                Mana = 0,
                Nivel = 1,
                Stamina = 6,
                Speed = 5,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Monster>().HasData(new Monster()
            {
                MonsterId = 3,
                CreatureId = 4,
                Name = "Wolf",
                HP = 40,
                Image = "",
                Mana = 0,
                Nivel = 2,
                Stamina = 6,
                Speed = 30,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedMonsterResource(ModelBuilder builder)
        {
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                MonsterId = 1,
                Value = "Dragón negro",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 1,
                ResourceTypeId = 2,
                MonsterId = 1,
                Value = "un gran dragón negro",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                MonsterId = 2,
                Value = "Limo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 1,
                ResourceTypeId = 2,
                MonsterId = 2,
                Value = "Una masa que lastima al contacto",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                MonsterId = 3,
                Value = "Lobo",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 1,
                ResourceTypeId = 2,
                MonsterId = 3,
                Value = "Una criatura salvaje",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                MonsterId = 1,
                Value = "Black Dragon",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 2,
                ResourceTypeId = 2,
                MonsterId = 1,
                Value = "A great black dragon",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                MonsterId = 2,
                Value = "Slime",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 2,
                ResourceTypeId = 2,
                MonsterId = 2,
                Value = "A mass that hurts on contact",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                MonsterId = 3,
                Value = "Wolf",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResource>().HasData(new MonsterResource()
            {
                LanguageId = 2,
                ResourceTypeId = 2,
                MonsterId = 3,
                Value = "A wild creature",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedMonsterResistance(ModelBuilder builder)
        {
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 1,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 2,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 3,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 4,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 5,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 6,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 7,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 1,
                DamageTypeId = 8,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 1,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 2,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 3,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 4,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 5,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 6,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 7,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 2,
                DamageTypeId = 8,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 1,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 2,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 3,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 4,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 5,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 6,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 7,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterResistance>().HasData(new MonsterResistance()
            {
                MonsterId = 3,
                DamageTypeId = 8,
                Value = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedMonsterZone(ModelBuilder builder)
        {
            builder.Entity<MonsterZone>().HasData(new MonsterZone()
            {
                ZoneId = 2,
                MonsterId = 2,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterZone>().HasData(new MonsterZone()
            {
                ZoneId = 2,
                MonsterId = 3,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedSkill(ModelBuilder builder)
        {
            builder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 1,
                Name = "Punch",
                Image = "PunchLogo",
                DamageTypeId = 7,
                DamageDice = 1,
                ManaCost = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 2,
                Name = "AcidPunch",
                Image = "AcidPunchLogo",
                DamageTypeId = 8,
                DamageDice = 1,
                ManaCost = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 3,
                Name = "Bite",
                Image = "BiteLogo",
                DamageTypeId = 7,
                DamageDice = 1,
                ManaCost = 0,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedSkillResource(ModelBuilder builder)
        {
            builder.Entity<SkillResource>().HasData(new SkillResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                SkillId = 1,
                Value = "Punch",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<SkillResource>().HasData(new SkillResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                SkillId = 1,
                Value = "Puño",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<SkillResource>().HasData(new SkillResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                SkillId = 2,
                Value = "Puño ácido",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<SkillResource>().HasData(new SkillResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                SkillId = 2,
                Value = "Acid punch",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<SkillResource>().HasData(new SkillResource()
            {
                LanguageId = 1,
                ResourceTypeId = 1,
                SkillId = 3,
                Value = "Mordisco",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<SkillResource>().HasData(new SkillResource()
            {
                LanguageId = 2,
                ResourceTypeId = 1,
                SkillId = 3,
                Value = "Bite",
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
        private void SeedMonsterSkill(ModelBuilder builder)
        {
            builder.Entity<MonsterSkill>().HasData(new MonsterSkill()
            {
                MonsterId = 1,
                SkillId = 1,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterSkill>().HasData(new MonsterSkill()
            {
                MonsterId = 1,
                SkillId = 3,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterSkill>().HasData(new MonsterSkill()
            {
                MonsterId = 2,
                SkillId = 2,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
            builder.Entity<MonsterSkill>().HasData(new MonsterSkill()
            {
                MonsterId = 3,
                SkillId = 3,
                CreatedBy = "Seed",
                CreatedOn = DateTime.Now
            });
        }
    }
}
