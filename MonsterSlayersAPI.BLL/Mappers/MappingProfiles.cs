using AutoMapper;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Request.Parametrization;
using MonsterSlayersAPI.BLL.Models.Result;
using System.Globalization;
using System.Xml.Serialization;

namespace MonsterSlayersAPI.BLL.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Battle
            CreateMap<StartBattleModel, Battle>();
            CreateMap<Battle, BattleResultModel>();

            CreateMap<BattleParticipant, ParticipantResultModel>()
                .ForMember(dest => dest.CreatureId, opt => opt.MapFrom(src => src.CreatureId))
                .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order));

            //Monster
            CreateMap<Monster, MonsterResultModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.MonsterResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.MonsterResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Description)).FirstOrDefault().Value));

            //Zone
            CreateMap<Zone, ZoneResultModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ZoneResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value));
            CreateMap<CreateZoneModel, Zone>();
            CreateMap<ResourceCreateModel, ZoneResource>();
        }
    }
}
