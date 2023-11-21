using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterSlayersAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "GAME");

            migrationBuilder.CreateTable(
                name: "Class",
                schema: "GAME",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthRate = table.Column<double>(type: "float", nullable: false),
                    DexterityRate = table.Column<double>(type: "float", nullable: false),
                    HPRate = table.Column<double>(type: "float", nullable: false),
                    FaithhRate = table.Column<double>(type: "float", nullable: false),
                    IntelligenceRate = table.Column<double>(type: "float", nullable: false),
                    ForPlayer = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Creature",
                schema: "GAME",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creature", x => x.CreatureId);
                });

            migrationBuilder.CreateTable(
                name: "DamageType",
                schema: "GAME",
                columns: table => new
                {
                    DamageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageType", x => x.DamageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "GAME",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "ResourceType",
                schema: "GAME",
                columns: table => new
                {
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceType", x => x.ResourceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                schema: "GAME",
                columns: table => new
                {
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.ZoneId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "GAME",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ASPUserId = table.Column<string>(type: "nvarchar(900)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "GAME",
                        principalTable: "Class",
                        principalColumn: "ClassId");
                });

            migrationBuilder.CreateTable(
                name: "Monster",
                schema: "GAME",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monster", x => x.MonsterId);
                    table.ForeignKey(
                        name: "FK_Monster_Creature_CreatureId",
                        column: x => x.CreatureId,
                        principalSchema: "GAME",
                        principalTable: "Creature",
                        principalColumn: "CreatureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                schema: "GAME",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageDice = table.Column<int>(type: "int", nullable: false),
                    ManaCost = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skill_DamageType_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalSchema: "GAME",
                        principalTable: "DamageType",
                        principalColumn: "DamageTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MessageResource",
                schema: "GAME",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    MessageName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageResource", x => new { x.LanguageId, x.MessageName });
                    table.ForeignKey(
                        name: "FK_MessageResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "GAME",
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassResource",
                schema: "GAME",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassResource", x => new { x.ClassId, x.LanguageId, x.ResourceTypeId });
                    table.ForeignKey(
                        name: "FK_ClassResource_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "GAME",
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "GAME",
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassResource_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "GAME",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DamageTypeResource",
                schema: "GAME",
                columns: table => new
                {
                    DamageTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypeResource", x => new { x.DamageTypeId, x.LanguageId, x.ResourceTypeId });
                    table.ForeignKey(
                        name: "FK_DamageTypeResource_DamageType_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalSchema: "GAME",
                        principalTable: "DamageType",
                        principalColumn: "DamageTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DamageTypeResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "GAME",
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DamageTypeResource_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "GAME",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Battle",
                schema: "GAME",
                columns: table => new
                {
                    BattleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeamWinner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battle", x => x.BattleId);
                    table.ForeignKey(
                        name: "FK_Battle_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalSchema: "GAME",
                        principalTable: "Zone",
                        principalColumn: "ZoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZoneResource",
                schema: "GAME",
                columns: table => new
                {
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneResource", x => new { x.ZoneId, x.LanguageId, x.ResourceTypeId });
                    table.ForeignKey(
                        name: "FK_ZoneResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "GAME",
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZoneResource_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "GAME",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZoneResource_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalSchema: "GAME",
                        principalTable: "Zone",
                        principalColumn: "ZoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                schema: "GAME",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthPoints = table.Column<int>(type: "int", nullable: false),
                    DexterityPoints = table.Column<int>(type: "int", nullable: false),
                    VitalityPoints = table.Column<int>(type: "int", nullable: false),
                    IntelligencePoints = table.Column<int>(type: "int", nullable: false),
                    FaithPoints = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Vitality = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Faith = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    CurrentHP = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CritRate = table.Column<int>(type: "int", nullable: false),
                    CritDamage = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Character_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "GAME",
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_Creature_CreatureId",
                        column: x => x.CreatureId,
                        principalSchema: "GAME",
                        principalTable: "Creature",
                        principalColumn: "CreatureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "GAME",
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalSchema: "GAME",
                        principalTable: "Zone",
                        principalColumn: "ZoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterResistance",
                schema: "GAME",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    DamageTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterResistance", x => new { x.MonsterId, x.DamageTypeId });
                    table.ForeignKey(
                        name: "FK_MonsterResistance_DamageType_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalSchema: "GAME",
                        principalTable: "DamageType",
                        principalColumn: "DamageTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterResistance_Monster_MonsterId",
                        column: x => x.MonsterId,
                        principalSchema: "GAME",
                        principalTable: "Monster",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterResource",
                schema: "GAME",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterResource", x => new { x.MonsterId, x.LanguageId, x.ResourceTypeId });
                    table.ForeignKey(
                        name: "FK_MonsterResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "GAME",
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterResource_Monster_MonsterId",
                        column: x => x.MonsterId,
                        principalSchema: "GAME",
                        principalTable: "Monster",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterResource_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "GAME",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterZone",
                schema: "GAME",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterZone", x => new { x.MonsterId, x.ZoneId });
                    table.ForeignKey(
                        name: "FK_MonsterZone_Monster_MonsterId",
                        column: x => x.MonsterId,
                        principalSchema: "GAME",
                        principalTable: "Monster",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterZone_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalSchema: "GAME",
                        principalTable: "Zone",
                        principalColumn: "ZoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassSkill",
                schema: "GAME",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSkill", x => new { x.ClassId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ClassSkill_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "GAME",
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "GAME",
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterSkill",
                schema: "GAME",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSkill", x => new { x.MonsterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_MonsterSkill_Monster_MonsterId",
                        column: x => x.MonsterId,
                        principalSchema: "GAME",
                        principalTable: "Monster",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "GAME",
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillResource",
                schema: "GAME",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillResource", x => new { x.SkillId, x.LanguageId, x.ResourceTypeId });
                    table.ForeignKey(
                        name: "FK_SkillResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "GAME",
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillResource_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "GAME",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillResource_Skill_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "GAME",
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BattleAction",
                schema: "GAME",
                columns: table => new
                {
                    BattleActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BattleId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleAction", x => x.BattleActionId);
                    table.ForeignKey(
                        name: "FK_BattleAction_Battle_BattleId",
                        column: x => x.BattleId,
                        principalSchema: "GAME",
                        principalTable: "Battle",
                        principalColumn: "BattleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleAction_Skill_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "GAME",
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BattleParticipant",
                schema: "GAME",
                columns: table => new
                {
                    BattleId = table.Column<int>(type: "int", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleParticipant", x => new { x.BattleId, x.CreatureId });
                    table.ForeignKey(
                        name: "FK_BattleParticipant_Battle_BattleId",
                        column: x => x.BattleId,
                        principalSchema: "GAME",
                        principalTable: "Battle",
                        principalColumn: "BattleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleParticipant_Creature_CreatureId",
                        column: x => x.CreatureId,
                        principalSchema: "GAME",
                        principalTable: "Creature",
                        principalColumn: "CreatureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterResistance",
                schema: "GAME",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    DamageTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterResistance", x => new { x.CharacterId, x.DamageTypeId });
                    table.ForeignKey(
                        name: "FK_CharacterResistance_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalSchema: "GAME",
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterResistance_DamageType_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalSchema: "GAME",
                        principalTable: "DamageType",
                        principalColumn: "DamageTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkill",
                schema: "GAME",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkill", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalSchema: "GAME",
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "GAME",
                        principalTable: "Class",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "GAME",
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BattleActionAffected",
                schema: "GAME",
                columns: table => new
                {
                    BattleActionAffectedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BattleActionId = table.Column<int>(type: "int", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BattleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleActionAffected", x => x.BattleActionAffectedId);
                    table.ForeignKey(
                        name: "FK_BattleActionAffected_BattleAction_BattleActionId",
                        column: x => x.BattleActionId,
                        principalSchema: "GAME",
                        principalTable: "BattleAction",
                        principalColumn: "BattleActionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattleActionAffected_Battle_BattleId",
                        column: x => x.BattleId,
                        principalSchema: "GAME",
                        principalTable: "Battle",
                        principalColumn: "BattleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattleActionAffected_Creature_CreatureId",
                        column: x => x.CreatureId,
                        principalSchema: "GAME",
                        principalTable: "Creature",
                        principalColumn: "CreatureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Class",
                columns: new[] { "ClassId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DexterityRate", "FaithhRate", "ForPlayer", "HPRate", "IntelligenceRate", "Logo", "ModifiedBy", "ModifiedOn", "Name", "StrengthRate" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4445), null, null, 1.0, 1.0, false, 1.0, 1.0, "MonsterLogo", null, null, "Monster", 1.0 },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4467), null, null, 1.0, 1.0, true, 1.0, 1.0, "MageLogo", null, null, "Mage", 1.0 },
                    { 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4483), null, null, 1.0, 1.0, true, 1.0, 1.0, "WarriorLogo", null, null, "Warrior", 1.0 },
                    { 4, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4499), null, null, 1.0, 1.0, true, 1.0, 1.0, "ClericLogo", null, null, "Cleric", 1.0 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Creature",
                columns: new[] { "CreatureId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3815), null, null, null, null },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3841), null, null, null, null },
                    { 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3882), null, null, null, null },
                    { 4, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3898), null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "DamageType",
                columns: new[] { "DamageTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Image", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4031), null, null, "LightningLogo", null, null, "Lightning" },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4050), null, null, "FireLogo", null, null, "Fire" },
                    { 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4066), null, null, "WaterLogo", null, null, "Water" },
                    { 4, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4083), null, null, "WindLogo", null, null, "Wind" },
                    { 5, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4099), null, null, "EarthLogo", null, null, "Earth" },
                    { 6, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4118), null, null, "RadiantLogo", null, null, "Radiant" },
                    { 7, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4134), null, null, "NeutralLogo", null, null, "Neutral" },
                    { 8, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4150), null, null, "AcidLogo", null, null, "Acid" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Language",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3948), null, null, null, null, "Español" },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3969), null, null, null, null, "English" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "ResourceType",
                columns: new[] { "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3988), null, null, null, null, "Name" },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4008), null, null, null, null, "Description" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "User",
                columns: new[] { "UserId", "ASPUserId", "ClassId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[] { 1, "", null, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3691), null, null, null, null, "Snorlax" });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Zone",
                columns: new[] { "ZoneId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Image", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4759), null, null, "CityBackGround", null, null, "City" },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4777), null, null, "FieldBackGround", null, null, "Field" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Character",
                columns: new[] { "CharacterId", "ClassId", "CreatedBy", "CreatedOn", "CreatureId", "CritDamage", "CritRate", "CurrentHP", "DeletedBy", "DeletedOn", "Dexterity", "DexterityPoints", "Experience", "Faith", "FaithPoints", "HP", "Image", "Intelligence", "IntelligencePoints", "Mana", "ModifiedBy", "ModifiedOn", "Name", "Nivel", "Speed", "Stamina", "Strength", "StrengthPoints", "UserId", "Vitality", "VitalityPoints", "ZoneId" },
                values: new object[] { 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(3925), 2, 2, 2, 10, null, null, 1, 1, 0, 1, 1, 10, "ImageR", 1, 1, 10, null, null, "Reonburakku", 1, 20, 6, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "ClassResource",
                columns: new[] { "ClassId", "LanguageId", "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4516), null, null, null, null, "Monstruo" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4571), null, null, null, null, "Criatura que habita el mundo y gusta de deborar humanos." },
                    { 1, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4645), null, null, null, null, "Monster" },
                    { 1, 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4698), null, null, null, null, "Creature that inhabits the world and likes to devour humans." },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4533), null, null, null, null, "Mago" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4586), null, null, null, null, "Estudiante de las artes arcanas, capaz de crear grandes daños elementales." },
                    { 2, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4659), null, null, null, null, "Wizard" },
                    { 2, 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4712), null, null, null, null, "Student of the arcane arts, capable of creating great elemental damage." },
                    { 3, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4546), null, null, null, null, "Guerrero" },
                    { 3, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4599), null, null, null, null, "Luchador entrenado para la batalla, fuerte y resistente." },
                    { 3, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4673), null, null, null, null, "Warrior" },
                    { 3, 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4724), null, null, null, null, "Fighter trained for battle, strong and resistant." },
                    { 4, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4558), null, null, null, null, "Clérigo" },
                    { 4, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4611), null, null, null, null, "Para muchos, enviado de los dioses, especialistas en curar y mejorar humanos." },
                    { 4, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4685), null, null, null, null, "Cleric" },
                    { 4, 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4737), null, null, null, null, "For many, sent from the gods, specialists in healing and improving humans." }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "DamageTypeResource",
                columns: new[] { "DamageTypeId", "LanguageId", "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4168), null, null, null, null, "Rayo" },
                    { 1, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4316), null, null, null, null, "Lightning" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4188), null, null, null, null, "Fuego" },
                    { 2, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4333), null, null, null, null, "Fire" },
                    { 3, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4203), null, null, null, null, "Agua" },
                    { 3, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4348), null, null, null, null, "Water" },
                    { 4, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4218), null, null, null, null, "Aire" },
                    { 4, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4361), null, null, null, null, "Wind" },
                    { 5, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4232), null, null, null, null, "Tierra" },
                    { 5, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4375), null, null, null, null, "Earth" },
                    { 6, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4248), null, null, null, null, "Radiante" },
                    { 6, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4390), null, null, null, null, "Radiant" },
                    { 7, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4285), null, null, null, null, "Neutro" },
                    { 7, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4404), null, null, null, null, "Neutral" },
                    { 8, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4301), null, null, null, null, "Ácido" },
                    { 8, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4419), null, null, null, null, "Acid" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MessageResource",
                columns: new[] { "LanguageId", "MessageName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, "AttackFail", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4894), null, null, null, null, "Ataque fallido." },
                    { 1, "AttackSuccess", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4876), null, null, null, null, "{target} recibe {damage} puntos de daño de {damagetype}." },
                    { 1, "Heal", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4910), null, null, null, null, "{target} recibe {heal} puntos de curación." },
                    { 1, "Loose", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4956), null, null, null, null, "Has perdido." },
                    { 1, "NotYourTurn", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4925), null, null, null, null, "No es tu turno." },
                    { 1, "Win", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4941), null, null, null, null, "Has ganado." },
                    { 2, "AttackFail", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4987), null, null, null, null, "Atack failed." },
                    { 2, "AttackSuccess", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4971), null, null, null, null, "{target} got {damage} {damagetype} damage proints." },
                    { 2, "Heal", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5024), null, null, null, null, "{target} got {heal} healing points." },
                    { 2, "Loose", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5071), null, null, null, null, "You Loose." },
                    { 2, "NotYourTurn", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5041), null, null, null, null, "Is not your turn." },
                    { 2, "Win", "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5056), null, null, null, null, "You win." }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Monster",
                columns: new[] { "MonsterId", "CreatedBy", "CreatedOn", "CreatureId", "DeletedBy", "DeletedOn", "HP", "Image", "Mana", "ModifiedBy", "ModifiedOn", "Name", "Nivel", "Speed", "Stamina" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5093), 1, null, null, 500, "", 50, null, null, "Black Dragon", 50, 50, 10 },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5113), 3, null, null, 10, "", 0, null, null, "Slime", 1, 5, 6 },
                    { 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5130), 4, null, null, 40, "", 0, null, null, "Wolf", 2, 30, 6 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Skill",
                columns: new[] { "SkillId", "CreatedBy", "CreatedOn", "DamageDice", "DamageTypeId", "DeletedBy", "DeletedOn", "Image", "ManaCost", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5776), 1, 7, null, null, "PunchLogo", 0, null, null, "Punch" },
                    { 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5797), 1, 8, null, null, "AcidPunchLogo", 0, null, null, "AcidPunch" },
                    { 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5815), 1, 7, null, null, "BiteLogo", 0, null, null, "Bite" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "ZoneResource",
                columns: new[] { "LanguageId", "ResourceTypeId", "ZoneId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4801), null, null, null, null, "Ciudad" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4835), null, null, null, null, "City" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4819), null, null, null, null, "Pradera" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(4852), null, null, null, null, "Field" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterResistance",
                columns: new[] { "DamageTypeId", "MonsterId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5350), null, null, null, null, 0 },
                    { 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5369), null, null, null, null, 0 },
                    { 3, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5404), null, null, null, null, 0 },
                    { 4, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5418), null, null, null, null, 0 },
                    { 5, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5432), null, null, null, null, 0 },
                    { 6, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5447), null, null, null, null, 0 },
                    { 7, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5461), null, null, null, null, 0 },
                    { 8, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5475), null, null, null, null, 0 },
                    { 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5489), null, null, null, null, 0 },
                    { 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5504), null, null, null, null, 0 },
                    { 3, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5517), null, null, null, null, 0 },
                    { 4, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5531), null, null, null, null, 0 },
                    { 5, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5545), null, null, null, null, 0 },
                    { 6, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5559), null, null, null, null, 0 },
                    { 7, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5572), null, null, null, null, 0 },
                    { 8, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5586), null, null, null, null, 0 },
                    { 1, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5600), null, null, null, null, 0 },
                    { 2, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5616), null, null, null, null, 0 },
                    { 3, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5630), null, null, null, null, 0 },
                    { 4, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5643), null, null, null, null, 0 },
                    { 5, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5658), null, null, null, null, 0 },
                    { 6, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5671), null, null, null, null, 0 },
                    { 7, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5686), null, null, null, null, 0 },
                    { 8, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5700), null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterResource",
                columns: new[] { "LanguageId", "MonsterId", "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5151), null, null, null, null, "Dragón negro" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5171), null, null, null, null, "un gran dragón negro" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5253), null, null, null, null, "Black Dragon" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5268), null, null, null, null, "A great black dragon" },
                    { 1, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5187), null, null, null, null, "Limo" },
                    { 1, 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5203), null, null, null, null, "Una masa que lastima al contacto" },
                    { 2, 2, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5284), null, null, null, null, "Slime" },
                    { 2, 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5300), null, null, null, null, "A mass that hurts on contact" },
                    { 1, 3, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5220), null, null, null, null, "Lobo" },
                    { 1, 3, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5237), null, null, null, null, "Una criatura salvaje" },
                    { 2, 3, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5316), null, null, null, null, "Wolf" },
                    { 2, 3, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5332), null, null, null, null, "A wild creature" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterSkill",
                columns: new[] { "MonsterId", "SkillId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5931), null, null, null, null },
                    { 1, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5950), null, null, null, null },
                    { 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5966), null, null, null, null },
                    { 3, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5981), null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterZone",
                columns: new[] { "MonsterId", "ZoneId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 2, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5720), null, null, null, null },
                    { 3, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5754), null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "SkillResource",
                columns: new[] { "LanguageId", "ResourceTypeId", "SkillId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5833), null, null, null, null, "Punch" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5851), null, null, null, null, "Puño" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5865), null, null, null, null, "Puño ácido" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5882), null, null, null, null, "Acid punch" },
                    { 1, 1, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5897), null, null, null, null, "Mordisco" },
                    { 2, 1, 3, "Seed", new DateTime(2023, 11, 20, 11, 50, 5, 783, DateTimeKind.Local).AddTicks(5912), null, null, null, null, "Bite" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battle_ZoneId",
                schema: "GAME",
                table: "Battle",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleAction_BattleId",
                schema: "GAME",
                table: "BattleAction",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleAction_SkillId",
                schema: "GAME",
                table: "BattleAction",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleActionAffected_BattleActionId",
                schema: "GAME",
                table: "BattleActionAffected",
                column: "BattleActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleActionAffected_BattleId",
                schema: "GAME",
                table: "BattleActionAffected",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleActionAffected_CreatureId",
                schema: "GAME",
                table: "BattleActionAffected",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleParticipant_CreatureId",
                schema: "GAME",
                table: "BattleParticipant",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_ClassId",
                schema: "GAME",
                table: "Character",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_CreatureId",
                schema: "GAME",
                table: "Character",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_UserId",
                schema: "GAME",
                table: "Character",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_ZoneId",
                schema: "GAME",
                table: "Character",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterResistance_DamageTypeId",
                schema: "GAME",
                table: "CharacterResistance",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_ClassId",
                schema: "GAME",
                table: "CharacterSkill",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_SkillId",
                schema: "GAME",
                table: "CharacterSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassResource_LanguageId",
                schema: "GAME",
                table: "ClassResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassResource_ResourceTypeId",
                schema: "GAME",
                table: "ClassResource",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSkill_SkillId",
                schema: "GAME",
                table: "ClassSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTypeResource_LanguageId",
                schema: "GAME",
                table: "DamageTypeResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTypeResource_ResourceTypeId",
                schema: "GAME",
                table: "DamageTypeResource",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Monster_CreatureId",
                schema: "GAME",
                table: "Monster",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterResistance_DamageTypeId",
                schema: "GAME",
                table: "MonsterResistance",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterResource_LanguageId",
                schema: "GAME",
                table: "MonsterResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterResource_ResourceTypeId",
                schema: "GAME",
                table: "MonsterResource",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSkill_SkillId",
                schema: "GAME",
                table: "MonsterSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterZone_ZoneId",
                schema: "GAME",
                table: "MonsterZone",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_DamageTypeId",
                schema: "GAME",
                table: "Skill",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillResource_LanguageId",
                schema: "GAME",
                table: "SkillResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillResource_ResourceTypeId",
                schema: "GAME",
                table: "SkillResource",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ClassId",
                schema: "GAME",
                table: "User",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ZoneResource_LanguageId",
                schema: "GAME",
                table: "ZoneResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ZoneResource_ResourceTypeId",
                schema: "GAME",
                table: "ZoneResource",
                column: "ResourceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleActionAffected",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "BattleParticipant",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "CharacterResistance",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "CharacterSkill",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "ClassResource",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "ClassSkill",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "DamageTypeResource",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "MessageResource",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "MonsterResistance",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "MonsterResource",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "MonsterSkill",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "MonsterZone",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "SkillResource",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "ZoneResource",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "BattleAction",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Character",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Monster",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "ResourceType",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Battle",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Skill",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "User",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Creature",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Zone",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "DamageType",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Class",
                schema: "GAME");
        }
    }
}
