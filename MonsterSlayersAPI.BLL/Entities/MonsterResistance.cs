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
    [PrimaryKey(nameof(MonsterId), nameof(DamageTypeId))]
    public class MonsterResistance : BaseEntity
    {
        public int MonsterId { get; set; }
        public int DamageTypeId { get; set; }
        public int Value { get; set; }


        [ForeignKey(nameof(MonsterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Monster? Monster { get; set; }
        [ForeignKey(nameof(DamageTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual DamageType? DamageType { get; set; }
    }
}
