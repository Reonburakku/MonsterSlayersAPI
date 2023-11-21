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
        IBattleRepository BattleRepository { get; }
        IBattleActionRepository BattleActionRepository { get; }
        IBattleParticipantRepository BattleParticipantRepository { get; }
        ICharacterRepository CharacterRepository { get; }
        ICharacterResistanceRepository CharacterResistanceRepository { get; }
        ICharacterSkillRepository haracterSkillRepository { get; }
        IClassRepository ClassRepository { get; }
        IClassResourceRepository ClassResourceRepository { get; }
        IClassSkillRepository ClassSkillRepository { get; }
        ICreatureRepository CreatureRepository { get; }
        IDamageTypeRepository DamageTypeRepository { get; }
        IDamageTypeResourceRepository DamageTypeResourceRepository { get; }
        ILanguageRepository LanguageRepository { get; }
        IMonsterRepository MonsterRepository { get; }
        IMonsterResourceRepository MonsterResourceRepository { get; }
        IMonsterResistanceRepository MonsterResistanceRepository { get; }
        IMonsterSkillRepository MonsterSkillRepository { get; }
        IMonsterZoneRepository MonsterZoneRepository { get; }
        IResourceTypeRepository ResourceTypeRepository { get; }
        ISkillRepository SkillRepository { get; }
        ISkillResourceRepository SkillResourceRepository { get; }
        IUserRepository UserRepository { get; }
        IZoneRepository ZoneRepository { get; }
        IZoneResourceRepository ZoneResourceRepository { get; }

        Task<int> CommitAsync();
    }
}
