﻿using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Repositories
{
    public interface IBattleParticipantRepository : IBaseRepository<BattleParticipant>
    {
        public Task<IEnumerable<BattleParticipant>> GetAllByBattleId(int battleId);
    }
}
