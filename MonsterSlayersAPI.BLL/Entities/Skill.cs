using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    public class Skill : BaseEntity
    {
        [Key] 
        public int SkillId { get; set; }

        public virtual ICollection<CharacterSkill>? CharacterSkills { get; set; }
        public virtual ICollection<ClassSkill>? ClassSkills { get; set; }
        public virtual ICollection<Ability>? Habilities { get; set; }
        public virtual ICollection<SkillResource>? SkillResources { get; set; }
    }
}
