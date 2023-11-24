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
    [PrimaryKey(nameof(CharacterId), nameof(AbilityId))]
    public class CharacterAbility : BaseEntity
    {
        public int CharacterId { get; set; }
        public int AbilityId { get; set; }


        [ForeignKey(nameof(CharacterId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Character? Character { get; set; }
        [ForeignKey(nameof(AbilityId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Ability? Ability { get; set; }

    }
}
