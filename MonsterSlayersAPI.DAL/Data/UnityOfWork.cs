using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.DAL.Repositories;
using MonsterSlayersAPI.Security.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.DAL.Data
{
    public  class UnityOfWork : IUnityOfWork
    {
        private readonly MonsterSlayersContext _context;
        private AbilityRepository _AbilityRepository;
        private AbilityResourceRepository _AbilityResourceRepository;
        private BattleRepository _battleRepository;
        private BattleActionRepository _battleActionRepository;
        private BattleParticipantRepository _battleParticipantRepository;
        private CharacterRepository _characterRepository;
        private CharacterAbilityRepository _characterAbilityRepository;
        private CharacterResistanceRepository _characterResistanceRepository;
        private CharacterSkillRepository _characterSkillRepository;
        private ClassRepository _classRepository;
        private ClassAbilityRepository _classAbilityRepository;
        private ClassResourceRepository _classResourceRepository;
        private CreatureRepository _creatureRepository;
        private DamageTypeRepository _damageTypeRepository;
        private DamageTypeResourceRepository _damageTypeResourceRepository;
        private LanguageRepository _languageRepository;
        private MonsterRepository _monsterRepository;
        private MonsterAbilityRepository _monsterAbilityRepository;
        private MonsterResourceRepository _monsterResourceRepository;
        private MonsterResistanceRepository _monsterResistanceRepository;
        private MonsterZoneRepository _monsterZoneRepository;
        private ResourceTypeRepository _resourceTypeRepository;
        private SkillRepository _skillRepository;
        private UserRepository _userRepository;
        private ZoneRepository _zoneRepository;
        private ZoneResourceRepository _zoneResourceRepository;

        public UnityOfWork(MonsterSlayersContext context)
        {
            this._context = context;
        }

        public IAbilityRepository AbilityRepository => _AbilityRepository ??= new AbilityRepository(_context);
        public IAbilityResourceRepository AbilityResourceRepository => _AbilityResourceRepository ??= new AbilityResourceRepository(_context);
        public IBattleRepository BattleRepository => _battleRepository ??= new BattleRepository(_context);
        public IBattleActionRepository BattleActionRepository => _battleActionRepository ??= new BattleActionRepository(_context);
        public IBattleParticipantRepository BattleParticipantRepository => _battleParticipantRepository ??= new BattleParticipantRepository(_context);
        public ICharacterRepository CharacterRepository => _characterRepository ??= new CharacterRepository(_context);
        public ICharacterAbilityRepository haracterAbilityRepository => _characterAbilityRepository ??= new CharacterAbilityRepository(_context);
        public ICharacterResistanceRepository CharacterResistanceRepository => _characterResistanceRepository ??= new CharacterResistanceRepository(_context);
        public ICharacterSkillRepository CharacterSkillRepository => _characterSkillRepository ??= new CharacterSkillRepository(_context);
        public IClassRepository ClassRepository => _classRepository ??= new ClassRepository(_context);
        public IClassAbilityRepository ClassAbilityRepository => _classAbilityRepository ??= new ClassAbilityRepository(_context);
        public IClassResourceRepository ClassResourceRepository => _classResourceRepository ??= new ClassResourceRepository(_context);
        public ICreatureRepository CreatureRepository => _creatureRepository ??= new CreatureRepository(_context);
        public IDamageTypeRepository DamageTypeRepository => _damageTypeRepository ??= new DamageTypeRepository(_context);
        public IDamageTypeResourceRepository DamageTypeResourceRepository => _damageTypeResourceRepository ??= new DamageTypeResourceRepository(_context);
        public ILanguageRepository LanguageRepository => _languageRepository ??= new LanguageRepository(_context);
        public IMonsterRepository MonsterRepository => _monsterRepository ??= new MonsterRepository(_context);
        public IMonsterAbilityRepository MonsterAbilityRepository => _monsterAbilityRepository ??= new MonsterAbilityRepository(_context);
        public IMonsterResourceRepository MonsterResourceRepository => _monsterResourceRepository ??= new MonsterResourceRepository(_context);
        public IMonsterResistanceRepository MonsterResistanceRepository => _monsterResistanceRepository ??= new MonsterResistanceRepository(_context);
        public IMonsterZoneRepository MonsterZoneRepository => _monsterZoneRepository ??= new MonsterZoneRepository(_context);
        public IResourceTypeRepository ResourceTypeRepository => _resourceTypeRepository ??= new ResourceTypeRepository(_context);
        public ISkillRepository SkillRepository => _skillRepository ??= new SkillRepository(_context);
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
        public IZoneRepository ZoneRepository => _zoneRepository ??= new ZoneRepository(_context);
        public IZoneResourceRepository ZoneResourceRepository => _zoneResourceRepository ??= new ZoneResourceRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
