using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Battle
{
    public class BattleActionModel
    {
        public int SourceCreatureId { get; set; }
        public int TargetCreatureId { get; set;}
        public int AbilityId { get; set; }
        public int Value { get; set; }
        public int Round { get; set; }
        public int Turn { get; set; }
    }
}
