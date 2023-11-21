﻿using Microsoft.EntityFrameworkCore;
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
    public class MonsterRepository : BaseRepository<Monster>, IMonsterRepository
    {
        public MonsterRepository(MonsterSlayersContext context) : base(context) { }

        public async Task<IEnumerable<Monster>> GetAllByZoneId(int zoneId, int languageId)
        {
            return await dbSet.Select(x => new Monster
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
            }).Where(x => x.MonsterZones.Any(mz => mz.ZoneId == zoneId)).ToArrayAsync();
        }

        public async Task<IEnumerable<Monster>> GetByIdRangeAsync(IEnumerable<int> values)
        {

            return await dbSet.Where(x => values.Contains(x.MonsterId)).ToArrayAsync();
        }

        public async Task<Monster> GetFullById(int monsterId, int languageId)
        {
            return await dbSet.Select(x => new Monster
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
            }).Where(x => x.MonsterId == monsterId).FirstAsync();
        }

        public async Task<IEnumerable<Monster>> GetInfoByIdRange(IEnumerable<int> monsterIds, int languageId)
        {
            return await dbSet.Select(x => new Monster
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
            }).Where(x => monsterIds.Contains(x.MonsterId)).ToArrayAsync();
        }
    }
}
