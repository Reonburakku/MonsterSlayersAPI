using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Interfaces
{
    public interface IUnityOfWork
    {
        IAbilityRepository AbilityRepository { get; }
        IAbilityResourceRepository AbilityResourceRepository { get; }
        IBattleRepository BattleRepository { get; }
        IBattleActionRepository BattleActionRepository { get; }
        IBattleParticipantRepository BattleParticipantRepository { get; }
        ICharacterRepository CharacterRepository { get; }
        ICharacterAbilityRepository haracterAbilityRepository { get; }
        ICharacterResistanceRepository CharacterResistanceRepository { get; }
        ICharacterSkillRepository CharacterSkillRepository { get; }
        IClassRepository ClassRepository { get; }
        IClassAbilityRepository ClassAbilityRepository { get; }
        IClassResourceRepository ClassResourceRepository { get; }
        ICreatureRepository CreatureRepository { get; }
        IDamageTypeRepository DamageTypeRepository { get; }
        IDamageTypeResourceRepository DamageTypeResourceRepository { get; }
        ILanguageRepository LanguageRepository { get; }
        IMonsterRepository MonsterRepository { get; }
        IMonsterAbilityRepository MonsterAbilityRepository { get; }
        IMonsterResourceRepository MonsterResourceRepository { get; }
        IMonsterResistanceRepository MonsterResistanceRepository { get; }
        IMonsterZoneRepository MonsterZoneRepository { get; }
        IResourceTypeRepository ResourceTypeRepository { get; }
        ISkillRepository SkillRepository { get; }
        IUserRepository UserRepository { get; }
        IZoneRepository ZoneRepository { get; }
        IZoneResourceRepository ZoneResourceRepository { get; }

        Task<int> CommitAsync();
    }
}
