using MonsterSlayersAPI.BLL.Models.Battle.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Battle
{
    public class EndBattleModel : BaseBattleModel
    {
        public int BattleId { get; set; }
        public string TeamWinner { get; set; }
    }
}
