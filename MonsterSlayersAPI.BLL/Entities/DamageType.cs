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
    public class DamageType : BaseEntity
    {
        [Key]
        public int DamageTypeId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }


        public virtual ICollection<DamageTypeResource>? DamageTypeResources { get; set; }
        public virtual ICollection<MonsterResistance>? MonsterResistances { get; set; }
        public virtual ICollection<CharacterResistance>? CharacterResistances { get; set; }
        public virtual ICollection<Skill>? Skills { get; set; }
    }
}
