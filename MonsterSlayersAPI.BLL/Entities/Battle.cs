using Microsoft.EntityFrameworkCore;
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
    public class Battle : BaseEntity
    {
        [Key]
        public int BattleId { get; set; }
        public int ZoneId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TeamWinner { get; set; }
        public int? Turn {  get; set; }
        public int Round {  get; set; }


        [ForeignKey(nameof(ZoneId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Zone? Zone { get; set; }
        public virtual ICollection<BattleParticipant>? BattleParticipants { get; set; }
        public virtual ICollection<BattleAction>? BattleActions { get; set; }
    }
}
