using MonsterSlayersAPI.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Battle
{
    public class MonsterBattleModel
    {
        public int MonsterId { get; set; }
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Nivel { get; set; }
        public int HP { get; set; }
        public string Image { get; set; }
        public int Stamina { get; set; }
        public int Mana { get; set; }
        public List<ResistanceBattleModel> ResistanceBattleModels { get; set; }
    }
}
