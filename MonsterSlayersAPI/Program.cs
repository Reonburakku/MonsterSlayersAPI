using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.DAL.Repositories.Base;
using MonsterSlayersAPI.Security.DAL.Data;
using System.Text;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.DAL.Repositories;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Services;
using MonsterSlayersAPI.DAL.Data;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

// For Entity Framework
builder.Services.AddDbContext<MonsterSlayersSecurityContext>(options => options.UseSqlServer(config.GetConnectionString("MonsterSlayersConnection")));
builder.Services.AddDbContext<MonsterSlayersContext>(options => options.UseSqlServer(config.GetConnectionString("MonsterSlayersConnection")));

// For Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<MonsterSlayersSecurityContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = config["JWT:ValidAudience"],
        ValidIssuer = config["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Secret"]))
    };
});

builder.Services.AddAuthorization();

// Repositories
builder.Services.AddScoped(typeof(IUnityOfWork), typeof(UnityOfWork));
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IBattleRepository), typeof(BattleRepository));
builder.Services.AddScoped(typeof(IBattleActionRepository), typeof(BattleActionRepository));
builder.Services.AddScoped(typeof(IBattleParticipantRepository), typeof(BattleParticipantRepository));
builder.Services.AddScoped(typeof(ICharacterRepository), typeof(CharacterRepository));
builder.Services.AddScoped(typeof(ICharacterResistanceRepository), typeof(CharacterResistanceRepository));
builder.Services.AddScoped(typeof(ICharacterSkillRepository), typeof(CharacterSkillRepository));
builder.Services.AddScoped(typeof(IClassRepository), typeof(ClassRepository));
builder.Services.AddScoped(typeof(IClassResourceRepository), typeof(ClassResourceRepository));
builder.Services.AddScoped(typeof(IClassSkillRepository), typeof(ClassSkillRepository));
builder.Services.AddScoped(typeof(ICreatureRepository), typeof(CreatureRepository));
builder.Services.AddScoped(typeof(IDamageTypeRepository), typeof(DamageTypeRepository));
builder.Services.AddScoped(typeof(IDamageTypeResourceRepository), typeof(DamageTypeResourceRepository));
builder.Services.AddScoped(typeof(ILanguageRepository), typeof(LanguageRepository));
builder.Services.AddScoped(typeof(IMonsterRepository), typeof(MonsterRepository));
builder.Services.AddScoped(typeof(IMonsterResourceRepository), typeof(MonsterResourceRepository));
builder.Services.AddScoped(typeof(IMonsterResistanceRepository), typeof(MonsterResistanceRepository));
builder.Services.AddScoped(typeof(IMonsterSkillRepository), typeof(MonsterSkillRepository));
builder.Services.AddScoped(typeof(IMonsterZoneRepository), typeof(MonsterZoneRepository));
builder.Services.AddScoped(typeof(IResourceTypeRepository), typeof(ResourceTypeRepository));
builder.Services.AddScoped(typeof(ISkillRepository), typeof(SkillRepository));
builder.Services.AddScoped(typeof(ISkillResourceRepository), typeof(SkillResourceRepository));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(IZoneRepository), typeof(ZoneRepository));
builder.Services.AddScoped(typeof(IZoneResourceRepository), typeof(ZoneResourceRepository));

// Services
builder.Services.AddScoped(typeof(IBattleService), typeof(BattleService));
builder.Services.AddScoped(typeof(IParametrizationService), typeof(ParametrizationService));

// Utilities
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
