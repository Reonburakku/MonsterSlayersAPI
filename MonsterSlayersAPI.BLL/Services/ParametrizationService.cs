using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models.Request.Base;
using MonsterSlayersAPI.BLL.Models.Request.Parametrization;
using MonsterSlayersAPI.BLL.Models.Result;
using MonsterSlayersAPI.BLL.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Services
{
    public class ParametrizationService : BaseService, IParametrizationService
    {
        public ParametrizationService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<string> Alive()
        {
            return "Parametrization Alive";
        }
        public async Task<ZoneResultModel> GetZoneByIdAsync(GetZoneByIdModel model)
        {
            Zone zoneEntity = await _unitOfWork.ZoneRepository.GetByIdAsync(model.ZoneId, model.LanguageId);
            ZoneResultModel zoneResultModel = _mapper.Map<ZoneResultModel>(zoneEntity);
            return zoneResultModel;
        }

        public async Task<IEnumerable<ZoneResultModel>> GetAllZonesAsync(BaseRequestModel model)
        {
            var zoneEntities = await _unitOfWork.ZoneRepository.GetAllAsync(model.LanguageId);
            IEnumerable<ZoneResultModel> zoneResultModel = _mapper.Map<IEnumerable<ZoneResultModel>>(zoneEntities);
            return zoneResultModel;
        }

        public async Task<CreateZoneModel> CreateZoneAsync(CreateZoneModel model)
        {
            Zone zone = _mapper.Map<Zone>(model);
            List<ZoneResource> zoneResources = _mapper.Map<List<ZoneResource>>(model.Resources);
            zone.ZoneResources = zoneResources;
            await _unitOfWork.ZoneRepository.Save(zone);
            _unitOfWork.CommitAsync();
            return model;
        }
    }
}
