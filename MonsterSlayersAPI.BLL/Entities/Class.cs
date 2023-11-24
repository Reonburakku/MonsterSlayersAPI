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
    public class Class : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public bool ForPlayer { get; set; }


        public virtual ICollection<ClassResource>? ClassResources { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<CharacterAbility>? CharacterAbility { get; set; }
        public virtual ICollection<ClassSkill>? ClassSkills { get; set; }
    }
}
