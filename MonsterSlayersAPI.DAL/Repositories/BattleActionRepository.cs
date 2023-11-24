﻿using MonsterSlayersAPI.BLL.Entities;
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
    public class BattleActionRepository : BaseRepository<BattleAction>, IBattleActionRepository
    {
        public BattleActionRepository(MonsterSlayersContext context) : base(context) { }
    }
}