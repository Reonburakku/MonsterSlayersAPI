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
    public class CreatureRepository : BaseRepository<Creature>, ICreatureRepository
    {
        public CreatureRepository(MonsterSlayersContext context, string source = "") : base(context, source) { }

        public async Task<Creature> GetInfoById(int creatureid, int languageId)
        {
            return await dbSet.Select(x => new Creature
            {
                CreatureId = x.CreatureId,
                Characters = x.Characters.Select(c => new Character
                {
                    CharacterId = c.CharacterId,
                    CharacterResistances = c.CharacterResistances,
                    Class = c.Class,
                    ClassId = c.ClassId,
                    CharacterAbilitys = c.CharacterAbilitys,
                    CreatureId = c.ClassId,
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
                }).ToArray(),
                Monsters = x.Monsters.Select(x => new Monster
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
            }).Where(x => x.CreatureId == creatureid).FirstAsync();
        }

        public async Task<IEnumerable<Creature>> GetInfoByIdRange(List<int> creatureids, int languageId)
        {
            return await dbSet.Select(x => new Creature
            {
                CreatureId = x.CreatureId,
                Characters = x.Characters.Select(c => new Character
                {
                    CharacterId = c.CharacterId,
                    CharacterResistances = c.CharacterResistances,
                    Class = c.Class,
                    ClassId = c.ClassId,
                    CharacterAbilitys = c.CharacterAbilitys,
                    CreatureId = c.ClassId,
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
                }).ToArray(),
                Monsters = x.Monsters.Select(x => new Monster
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
            }).Where(x => creatureids.Contains(x.CreatureId)).ToArrayAsync();
        }
    }
}
