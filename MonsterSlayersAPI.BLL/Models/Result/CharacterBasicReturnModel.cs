using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Result
{
    public class CharacterBasicReturnModel : BaseEntity
    {
        public int CharacterId { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public int Nivel { get; set; }
        public int Experience { get; set; }
        public string Image { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
        public int Faith { get; set; }
        public int HP { get; set; }
        public int CurrentHP { get; set; }
        public int Speed { get; set; }
        public int CritRate { get; set; }
        public int CritDamage { get; set; }
        public int Stamina { get; set; }
        public int Mana { get; set; }
    }
}
