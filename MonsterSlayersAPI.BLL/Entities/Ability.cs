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
    public class Ability : BaseEntity
    {
        [Key]
        public int AbilityId { get; set; }
        public int DamageTypeId { get; set; }
        public int SkillId { get; set; }
        public string Image { get; set; }
        public int DamageDice { get; set; }
        public int ManaCost { get; set; }
        public int StaminaCost { get; set; }

        [ForeignKey(nameof(DamageTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual DamageType? DamageType { get; set; }
        [ForeignKey(nameof(SkillId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Skill? Skill { get; set; }
        public virtual ICollection<AbilityResource>? AbilityResources { get; set; }
        public virtual ICollection<CharacterAbility>? CharacterAbilitys { get; set; }
        public virtual ICollection<MonsterAbility>? MonsterAbilitys { get; set; }
        public virtual ICollection<BattleAction>? BattleActions { get; set; }
        public virtual ICollection<ClassAbility>? ClassAbilitys { get; set; }
    }
}
