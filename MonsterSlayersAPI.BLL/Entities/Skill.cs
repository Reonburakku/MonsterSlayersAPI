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
    public class Skill : BaseEntity
    {
        [Key]
        public int SkillId { get; set; }
        public int DamageTypeId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int DamageDice { get; set; }
        public int ManaCost { get; set; }

        [ForeignKey(nameof(DamageTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual DamageType? DamageType { get; set; }
        public virtual ICollection<SkillResource>? SkillResources { get; set; }
        public virtual ICollection<CharacterSkill>? CharacterSkills { get; set; }
        public virtual ICollection<MonsterSkill>? MonsterSkills { get; set; }
        public virtual ICollection<BattleAction>? BattleActions { get; set; }
    }
}
