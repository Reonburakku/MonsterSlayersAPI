using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    public class Language : BaseEntity
    {
        [Key]
        public int LanguageId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<ClassResource>? ClassResources { get; set; }
        public virtual ICollection<DamageTypeResource>? DamageTypeResources { get; set; }
        public virtual ICollection<MonsterResource>? MonsterResources { get; set; }
        public virtual ICollection<SkillResource>? SkillResources { get; set; }
        public virtual ICollection<MessageResource>? MessageResources { get; set; }
    }
}
