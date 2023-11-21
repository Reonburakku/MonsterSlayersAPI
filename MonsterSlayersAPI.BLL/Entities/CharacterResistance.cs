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
    [PrimaryKey(nameof(CharacterId), nameof(DamageTypeId))]
    public class CharacterResistance : BaseEntity
    {
        public int CharacterId { get; set; }
        public int DamageTypeId { get; set; }
        public int Value { get; set; }


        [ForeignKey(nameof(CharacterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Character? Character { get; set; }
        [ForeignKey(nameof(DamageTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual DamageType? DamageType { get; set; }
    }
}
