using MonsterSlayersAPI.BLL.Models.Request.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Request.Game
{
    public class EndTurnModel : BaseRequestModel
    {
        public int BattleId { get; set; }
        public int CreatureId { get; set; }
    }
}
