using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
namespace MonsterSlayersAPI.BLL.Entities
{

    [PrimaryKey(nameof(BattleId), nameof(CreatureId))]
    public class BattleParticipant : BaseEntity
    {
        public int BattleId { get; set; }
        public int CreatureId { get; set; }
        public int Order { get; set; }
        public string Team { get; set; }


        [ForeignKey(nameof(BattleId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Battle Battle { get; set; }
        [ForeignKey(nameof(CreatureId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Creature Creature { get; set; }
    }
}
