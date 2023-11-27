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

        public string Source {  get; set; }

        public UnityOfWork(MonsterSlayersContext context)
        {
            this._context = context;
        }

        public IAbilityRepository AbilityRepository => _AbilityRepository ??= new AbilityRepository(_context, Source);
        public IAbilityResourceRepository AbilityResourceRepository => _AbilityResourceRepository ??= new AbilityResourceRepository(_context, Source);
        public IBattleRepository BattleRepository => _battleRepository ??= new BattleRepository(_context, Source);
        public IBattleActionRepository BattleActionRepository => _battleActionRepository ??= new BattleActionRepository(_context, Source);
        public IBattleParticipantRepository BattleParticipantRepository => _battleParticipantRepository ??= new BattleParticipantRepository(_context, Source);
        public ICharacterRepository CharacterRepository => _characterRepository ??= new CharacterRepository(_context, Source);
        public ICharacterAbilityRepository haracterAbilityRepository => _characterAbilityRepository ??= new CharacterAbilityRepository(_context, Source);
        public ICharacterResistanceRepository CharacterResistanceRepository => _characterResistanceRepository ??= new CharacterResistanceRepository(_context, Source);
        public ICharacterSkillRepository CharacterSkillRepository => _characterSkillRepository ??= new CharacterSkillRepository(_context, Source);
        public IClassRepository ClassRepository => _classRepository ??= new ClassRepository(_context, Source);
        public IClassAbilityRepository ClassAbilityRepository => _classAbilityRepository ??= new ClassAbilityRepository(_context, Source);
        public IClassResourceRepository ClassResourceRepository => _classResourceRepository ??= new ClassResourceRepository(_context, Source);
        public ICreatureRepository CreatureRepository => _creatureRepository ??= new CreatureRepository(_context, Source);
        public IDamageTypeRepository DamageTypeRepository => _damageTypeRepository ??= new DamageTypeRepository(_context, Source);
        public IDamageTypeResourceRepository DamageTypeResourceRepository => _damageTypeResourceRepository ??= new DamageTypeResourceRepository(_context, Source);
        public ILanguageRepository LanguageRepository => _languageRepository ??= new LanguageRepository(_context, Source);
        public IMonsterRepository MonsterRepository => _monsterRepository ??= new MonsterRepository(_context, Source);
        public IMonsterAbilityRepository MonsterAbilityRepository => _monsterAbilityRepository ??= new MonsterAbilityRepository(_context, Source);
        public IMonsterResourceRepository MonsterResourceRepository => _monsterResourceRepository ??= new MonsterResourceRepository(_context, Source);
        public IMonsterResistanceRepository MonsterResistanceRepository => _monsterResistanceRepository ??= new MonsterResistanceRepository(_context, Source);
        public IMonsterZoneRepository MonsterZoneRepository => _monsterZoneRepository ??= new MonsterZoneRepository(_context, Source);
        public IResourceTypeRepository ResourceTypeRepository => _resourceTypeRepository ??= new ResourceTypeRepository(_context, Source);
        public ISkillRepository SkillRepository => _skillRepository ??= new SkillRepository(_context, Source);
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context, Source);
        public IZoneRepository ZoneRepository => _zoneRepository ??= new ZoneRepository(_context, Source);
        public IZoneResourceRepository ZoneResourceRepository => _zoneResourceRepository ??= new ZoneResourceRepository(_context, Source);


        public int CommitAsync()
        {
            
            return _context.SaveChanges(Source);
        }
    }
}
