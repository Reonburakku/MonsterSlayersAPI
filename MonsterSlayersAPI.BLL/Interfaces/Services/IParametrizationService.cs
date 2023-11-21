using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Models.Request.Base;
using MonsterSlayersAPI.BLL.Models.Request.Parametrization;
using MonsterSlayersAPI.BLL.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces.Services
{
    public interface IParametrizationService
    {
        Task<IEnumerable<ZoneResultModel>> GetAllZonesAsync(BaseRequestModel model);
        Task<ZoneResultModel> GetZoneByIdAsync(GetZoneByIdModel model);
        Task<CreateZoneModel> CreateZoneAsync(CreateZoneModel model);
    }
}
