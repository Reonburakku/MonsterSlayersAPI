using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    public class Zone : BaseEntity
    {
        [Key]
        public int ZoneId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public ICollection<ZoneResource>? ZoneResources { get; set; }
        public ICollection<MonsterZone>? MonsterZones { get; set; }
    }
}
