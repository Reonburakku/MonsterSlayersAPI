using MonsterSlayersAPI.BLL.Models.Request.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Models.Request.Parametrization
{
    public class CreateZoneModel : BaseRequestModel
    {
        public string Name { get; set; }
        public List<ResourceCreateModel> Resources { get; set; }
    }
}
