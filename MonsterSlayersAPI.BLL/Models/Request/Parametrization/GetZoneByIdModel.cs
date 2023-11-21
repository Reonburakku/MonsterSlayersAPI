using MonsterSlayersAPI.BLL.Models.Request.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Request.Parametrization
{
    public class GetZoneByIdModel : BaseRequestModel
    {
        public int ZoneId { get; set; }
    }
}
