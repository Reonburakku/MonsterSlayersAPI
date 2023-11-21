using MonsterSlayersAPI.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Result
{
    public class ParticipantResultModel
    {
        public int CreatureId { get; set; }
        public int Name { get; set; }
        public int Order { get; set; }
        public Character? Character { get; set; }
        public Monster? Monster { get; set; }
    }
}
