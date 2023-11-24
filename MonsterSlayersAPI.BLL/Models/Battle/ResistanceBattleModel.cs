using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Battle
{
    public class ResistanceBattleModel
    {
        public int DamageTypeId { get; set; }
        public string DamageName { get; set; }
        public string DamageImage { get; set; }
        public double Resistance { get; set; }
    }
}
