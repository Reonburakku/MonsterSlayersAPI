using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    public class Monster : BaseEntity
    {
        [Key]
        public int MonsterId { get; set; }
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public int Nivel { get; set; }
        public int HP { get; set; }
        public string Image { get; set; }
        public int Stamina { get; set; }
        public int Mana { get; set; }
        public int Speed { get; set; }


        [ForeignKey(nameof(CreatureId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Creature? Creature { get; set; }
        public virtual ICollection<MonsterResource>? MonsterResources { get; set; }
        public virtual ICollection<MonsterAbility>? MonsterAbilitys { get; set; }
        public virtual ICollection<MonsterResistance>? MonsterResistances { get; set; }
        public virtual ICollection<MonsterZone>? MonsterZones { get; set; }
    }
}
