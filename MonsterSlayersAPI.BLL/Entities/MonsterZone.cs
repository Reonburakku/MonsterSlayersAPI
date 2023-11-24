using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities
{
    [PrimaryKey(nameof(MonsterId), nameof(ZoneId))]
    public class MonsterZone : BaseEntity
    {
        public int MonsterId { get; set; }
        public int ZoneId { get; set; }


        [ForeignKey(nameof(MonsterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Monster? Monster { get; set; }
        [ForeignKey(nameof(ZoneId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Zone? Zone { get; set; }
    }
}
