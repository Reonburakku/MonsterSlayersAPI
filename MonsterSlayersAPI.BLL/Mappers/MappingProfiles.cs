using AutoMapper;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Models.Battle;
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
            //Character
            CreateMap<Character, CharacterInfoResultModel>();
            CreateMap<Character, CharacterBattleModel>()
                .ForMember(dest => dest.CurrentHP, opt => opt.MapFrom(src => src.HP)).ReverseMap();
            CreateMap<CharacterSkill, SkillBattleModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Skill.SkillResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value));
            CreateMap<CharacterResistance, ResistanceBattleModel>()
                .ForMember(dest => dest.Resistance, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.DamageTypeId, opt => opt.MapFrom(src => src.DamageType.DamageTypeId))
                .ForMember(dest => dest.DamageName, opt => opt.MapFrom(src => src.DamageType.DamageTypeResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value))
                .ForMember(dest => dest.DamageImage, opt => opt.MapFrom(src => src.DamageType.Image));

            //Battle
            CreateMap<StartBattleModel, Battle>();
            CreateMap<Battle, BattleResultModel>();

            CreateMap<BattleParticipant, ParticipantResultModel>()
                .ForMember(dest => dest.CreatureId, opt => opt.MapFrom(src => src.CreatureId))
                .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order));


            CreateMap<BattleAction, BattleActionModel>()
                .ForMember(dest => dest.SourceCreatureId, opt => opt.MapFrom(src => src.BattleActionAffecteds.First(x => x.Type == "Source").CreatureId))
                .ForMember(dest => dest.TargetCreatureId, opt => opt.MapFrom(src => src.BattleActionAffecteds.First(x => x.Type == "Target").CreatureId));

            //Monster
            CreateMap<Monster, MonsterBattleModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.MonsterResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.MonsterResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Description)).FirstOrDefault().Value));
            CreateMap<Monster, MonsterResultModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.MonsterResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.MonsterResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Description)).FirstOrDefault().Value));
            CreateMap<MonsterResistance, ResistanceBattleModel>()
                .ForMember(dest => dest.Resistance, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.DamageTypeId, opt => opt.MapFrom(src => src.DamageType.DamageTypeId))
                .ForMember(dest => dest.DamageName, opt => opt.MapFrom(src => src.DamageType.DamageTypeResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value))
                .ForMember(dest => dest.DamageImage, opt => opt.MapFrom(src => src.DamageType.Image));

            //Zone
            CreateMap<Zone, ZoneResultModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ZoneResources.Where(z => (z.ResourceTypeId == (int)ResourceTypeEnum.Name)).FirstOrDefault().Value));
            CreateMap<CreateZoneModel, Zone>();
            CreateMap<ResourceCreateModel, ZoneResource>();
        }
    }
}
