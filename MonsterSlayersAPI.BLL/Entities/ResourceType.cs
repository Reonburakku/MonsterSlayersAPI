using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    public class ResourceType : BaseEntity
    {
        [Key]
        public int ResourceTypeId { get; set; }
        public string Value { get; set; }


        public virtual ICollection<ClassResource>? ClassResources { get; set; }
        public virtual ICollection<DamageTypeResource>? DamageTypeResources { get; set; }
        public virtual ICollection<MonsterResource>? MonsterResources { get; set; }
        public virtual ICollection<AbilityResource>? AbilityResources { get; set; }
    }
}
