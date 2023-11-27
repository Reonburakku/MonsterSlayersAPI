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
    public class Character : BaseEntity
    {
        [Key]
        public int CharacterId { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public int CreatureId { get; set; }
        public int ZoneId { get; set; }
        public string Name { get; set; }
        public int Nivel { get; set; }
        public int Experience { get; set; }
        public string Image { get; set; }
        public int HP { get; set; }
        public int Speed { get; set; }
        public double CritRate { get; set; }
        public double CritDamage { get; set; }
        public int Stamina { get; set; }
        public int Mana { get; set; }


        [ForeignKey(nameof(CreatureId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Creature? Creature { get; set; }
        [ForeignKey(nameof(UserId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual User? User { get; set; }
        [ForeignKey(nameof(ClassId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Class? Class { get; set; }
        [ForeignKey(nameof(ZoneId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Zone? Zone { get; set; }
        public virtual ICollection<CharacterResistance>? CharacterResistances { get; set;}
        public virtual ICollection<CharacterAbility>? CharacterAbilitys { get; set; }
        public virtual ICollection<CharacterSkill>? CharacterSkills { get; set; }
    }
}