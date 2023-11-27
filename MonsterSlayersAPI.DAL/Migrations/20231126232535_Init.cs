using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterSlayersAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForPlayer = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Skill",
                schema: "GAME",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                schema: "GAME",
                columns: table => new
                {
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "MessageResource",
                schema: "GAME",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    MessageName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Ability",
                schema: "GAME",
                columns: table => new
                {
                    AbilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageTypeId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageDice = table.Column<int>(type: "int", nullable: false),
                    ManaCost = table.Column<int>(type: "int", nullable: false),
                    StaminaCost = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.AbilityId);
                    table.ForeignKey(
                        name: "FK_Ability_DamageType_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalSchema: "GAME",
                        principalTable: "DamageType",
                        principalColumn: "DamageTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ability_Skill_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "GAME",
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassSkill",
                schema: "GAME",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "SkillResource",
                schema: "GAME",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Turn = table.Column<int>(type: "int", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    HP = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CritRate = table.Column<double>(type: "float", nullable: false),
                    CritDamage = table.Column<double>(type: "float", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Value = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "AbilityResource",
                schema: "GAME",
                columns: table => new
                {
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityResource", x => new { x.AbilityId, x.LanguageId, x.ResourceTypeId });
                    table.ForeignKey(
                        name: "FK_AbilityResource_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalSchema: "GAME",
                        principalTable: "Ability",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbilityResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "GAME",
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbilityResource_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalSchema: "GAME",
                        principalTable: "ResourceType",
                        principalColumn: "ResourceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassAbility",
                schema: "GAME",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAbility", x => new { x.ClassId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_ClassAbility_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalSchema: "GAME",
                        principalTable: "Ability",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassAbility_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "GAME",
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterAbility",
                schema: "GAME",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterAbility", x => new { x.MonsterId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_MonsterAbility_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalSchema: "GAME",
                        principalTable: "Ability",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterAbility_Monster_MonsterId",
                        column: x => x.MonsterId,
                        principalSchema: "GAME",
                        principalTable: "Monster",
                        principalColumn: "MonsterId",
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
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Turn = table.Column<int>(type: "int", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleAction", x => x.BattleActionId);
                    table.ForeignKey(
                        name: "FK_BattleAction_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalSchema: "GAME",
                        principalTable: "Ability",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleAction_Battle_BattleId",
                        column: x => x.BattleId,
                        principalSchema: "GAME",
                        principalTable: "Battle",
                        principalColumn: "BattleId",
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
                    IsMonster = table.Column<bool>(type: "bit", nullable: false),
                    ParticipantData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CharacterAbility",
                schema: "GAME",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAbility", x => new { x.CharacterId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalSchema: "GAME",
                        principalTable: "Ability",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalSchema: "GAME",
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "GAME",
                        principalTable: "Class",
                        principalColumn: "ClassId");
                });

            migrationBuilder.CreateTable(
                name: "CharacterResistance",
                schema: "GAME",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    DamageTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Total = table.Column<int>(type: "int", nullable: false),
                    Real = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    BattleId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "BattleId");
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
                columns: new[] { "ClassId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ForPlayer", "Image", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4470), null, null, false, "MonsterLogo", null, null },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4491), null, null, true, "MageLogo", null, null },
                    { 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4510), null, null, true, "WarriorLogo", null, null },
                    { 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4529), null, null, true, "ClericLogo", null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Creature",
                columns: new[] { "CreatureId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3165), null, null, null, null },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3204), null, null, null, null },
                    { 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3225), null, null, null, null },
                    { 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3244), null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "DamageType",
                columns: new[] { "DamageTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Image", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3791), null, null, "LightningLogo", null, null },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3810), null, null, "FireLogo", null, null },
                    { 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3828), null, null, "WaterLogo", null, null },
                    { 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3870), null, null, "WindLogo", null, null },
                    { 5, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3887), null, null, "EarthLogo", null, null },
                    { 6, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3905), null, null, "RadiantLogo", null, null },
                    { 7, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3922), null, null, "NeutralLogo", null, null },
                    { 8, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3939), null, null, "AcidLogo", null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Language",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3707), null, null, null, null, "Español" },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3726), null, null, null, null, "English" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "ResourceType",
                columns: new[] { "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3750), null, null, null, null, "Name" },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3769), null, null, null, null, "Description" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Skill",
                columns: new[] { "SkillId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3301), null, null, null, null },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3323), null, null, null, null },
                    { 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3342), null, null, null, null },
                    { 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3362), null, null, null, null },
                    { 5, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3380), null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "User",
                columns: new[] { "UserId", "ASPUserId", "ClassId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[] { 1, "", null, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(2959), null, null, null, null, "Snorlax" });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Zone",
                columns: new[] { "ZoneId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Image", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4977), null, null, "CityBackGround", null, null },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4999), null, null, "FieldBackGround", null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Ability",
                columns: new[] { "AbilityId", "CreatedBy", "CreatedOn", "DamageDice", "DamageTypeId", "DeletedBy", "DeletedOn", "Image", "ManaCost", "ModifiedBy", "ModifiedOn", "SkillId", "StaminaCost" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6183), 1, 7, null, null, "PunchLogo", 0, null, null, 1, 3 },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6205), 1, 8, null, null, "AcidPunchLogo", 2, null, null, 4, 3 },
                    { 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6223), 1, 7, null, null, "BiteLogo", 0, null, null, 1, 3 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Character",
                columns: new[] { "CharacterId", "ClassId", "CreatedBy", "CreatedOn", "CreatureId", "CritDamage", "CritRate", "DeletedBy", "DeletedOn", "Experience", "HP", "Image", "Mana", "ModifiedBy", "ModifiedOn", "Name", "Nivel", "Speed", "Stamina", "UserId", "ZoneId" },
                values: new object[] { 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3272), 2, 2.0, 2.0, null, null, 0, 10, "ImageR", 20, null, null, "Reonburakku", 1, 20, 6, 1, 1 });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "ClassResource",
                columns: new[] { "ClassId", "LanguageId", "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4651), null, null, null, null, "Monstruo" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4729), null, null, null, null, "Criatura que habita el mundo y gusta de deborar humanos." },
                    { 1, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4824), null, null, null, null, "Monster" },
                    { 1, 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4898), null, null, null, null, "Creature that inhabits the world and likes to devour humans." },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4674), null, null, null, null, "Mago" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4747), null, null, null, null, "Estudiante de las artes arcanas, capaz de crear grandes daños elementales." },
                    { 2, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4843), null, null, null, null, "Wizard" },
                    { 2, 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4917), null, null, null, null, "Student of the arcane arts, capable of creating great elemental damage." },
                    { 3, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4693), null, null, null, null, "Guerrero" },
                    { 3, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4787), null, null, null, null, "Luchador entrenado para la batalla, fuerte y resistente." },
                    { 3, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4862), null, null, null, null, "Warrior" },
                    { 3, 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4935), null, null, null, null, "Fighter trained for battle, strong and resistant." },
                    { 4, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4711), null, null, null, null, "Clérigo" },
                    { 4, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4805), null, null, null, null, "Para muchos, enviado de los dioses, especialistas en curar y mejorar humanos." },
                    { 4, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4879), null, null, null, null, "Cleric" },
                    { 4, 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4954), null, null, null, null, "For many, sent from the gods, specialists in healing and improving humans." }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "ClassSkill",
                columns: new[] { "ClassId", "SkillId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Rate" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4553), null, null, null, null, 1.0 },
                    { 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4574), null, null, null, null, 2.0 },
                    { 1, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4590), null, null, null, null, 1.0 },
                    { 1, 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4607), null, null, null, null, 3.0 },
                    { 1, 5, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4624), null, null, null, null, 1.0 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "DamageTypeResource",
                columns: new[] { "DamageTypeId", "LanguageId", "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3967), null, null, null, null, "Rayo" },
                    { 1, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4121), null, null, null, null, "Lightning" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3989), null, null, null, null, "Fuego" },
                    { 2, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4139), null, null, null, null, "Fire" },
                    { 3, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4008), null, null, null, null, "Agua" },
                    { 3, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4157), null, null, null, null, "Water" },
                    { 4, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4026), null, null, null, null, "Aire" },
                    { 4, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4175), null, null, null, null, "Wind" },
                    { 5, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4045), null, null, null, null, "Tierra" },
                    { 5, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4193), null, null, null, null, "Earth" },
                    { 6, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4064), null, null, null, null, "Radiante" },
                    { 6, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4211), null, null, null, null, "Radiant" },
                    { 7, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4083), null, null, null, null, "Neutro" },
                    { 7, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4230), null, null, null, null, "Neutral" },
                    { 8, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4102), null, null, null, null, "Ácido" },
                    { 8, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4248), null, null, null, null, "Acid" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MessageResource",
                columns: new[] { "LanguageId", "MessageName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, "AttackFail", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5133), null, null, null, null, "Ataque fallido." },
                    { 1, "AttackSuccess", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5110), null, null, null, null, "{target} recibe {damage} puntos de daño de {damagetype}." },
                    { 1, "Heal", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5150), null, null, null, null, "{target} recibe {heal} puntos de curación." },
                    { 1, "Loose", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5228), null, null, null, null, "Has perdido." },
                    { 1, "NotYourTurn", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5170), null, null, null, null, "No es tu turno." },
                    { 1, "Win", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5187), null, null, null, null, "Has ganado." },
                    { 2, "AttackFail", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5266), null, null, null, null, "Atack failed." },
                    { 2, "AttackSuccess", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5248), null, null, null, null, "{target} got {damage} {damagetype} damage proints." },
                    { 2, "Heal", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5285), null, null, null, null, "{target} got {heal} healing points." },
                    { 2, "Loose", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5339), null, null, null, null, "You Loose." },
                    { 2, "NotYourTurn", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5304), null, null, null, null, "Is not your turn." },
                    { 2, "Win", "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5321), null, null, null, null, "You win." }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "Monster",
                columns: new[] { "MonsterId", "CreatedBy", "CreatedOn", "CreatureId", "DeletedBy", "DeletedOn", "HP", "Image", "Mana", "ModifiedBy", "ModifiedOn", "Nivel", "Speed", "Stamina" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5369), 1, null, null, 500, "", 50, null, null, 50, 50, 10 },
                    { 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5392), 3, null, null, 10, "", 0, null, null, 1, 5, 6 },
                    { 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5410), 4, null, null, 40, "", 0, null, null, 2, 30, 6 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "SkillResource",
                columns: new[] { "LanguageId", "ResourceTypeId", "SkillId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3407), null, null, null, null, "Fuerza" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3525), null, null, null, null, "Strength" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3450), null, null, null, null, "Destreza" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3543), null, null, null, null, "Dexterity" },
                    { 1, 1, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3470), null, null, null, null, "Vitalidad" },
                    { 2, 1, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3561), null, null, null, null, "Vitality" },
                    { 1, 1, 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3488), null, null, null, null, "Inteligencia" },
                    { 2, 1, 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3579), null, null, null, null, "Intelligence" },
                    { 1, 1, 5, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3506), null, null, null, null, "Fé" },
                    { 2, 1, 5, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3598), null, null, null, null, "Faith" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "ZoneResource",
                columns: new[] { "LanguageId", "ResourceTypeId", "ZoneId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5025), null, null, null, null, "Ciudad" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5068), null, null, null, null, "City" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5049), null, null, null, null, "Pradera" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5087), null, null, null, null, "Field" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "AbilityResource",
                columns: new[] { "AbilityId", "LanguageId", "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6249), null, null, null, null, "Punch" },
                    { 1, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6267), null, null, null, null, "Puño" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6284), null, null, null, null, "Puño ácido" },
                    { 2, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6301), null, null, null, null, "Acid punch" },
                    { 3, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6318), null, null, null, null, "Mordisco" },
                    { 3, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6336), null, null, null, null, "Bite" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "CharacterResistance",
                columns: new[] { "CharacterId", "DamageTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4273), null, null, null, null, 0.0 },
                    { 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4336), null, null, null, null, 0.0 },
                    { 1, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4354), null, null, null, null, 0.0 },
                    { 1, 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4372), null, null, null, null, 0.0 },
                    { 1, 5, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4389), null, null, null, null, 0.0 },
                    { 1, 6, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4409), null, null, null, null, 0.0 },
                    { 1, 7, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4427), null, null, null, null, 0.0 },
                    { 1, 8, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(4443), null, null, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "CharacterSkill",
                columns: new[] { "CharacterId", "SkillId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Real", "Total" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3621), null, null, null, null, 1, 1 },
                    { 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3639), null, null, null, null, 2, 1 },
                    { 1, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3654), null, null, null, null, 1, 1 },
                    { 1, 4, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3671), null, null, null, null, 3, 1 },
                    { 1, 5, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(3686), null, null, null, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterAbility",
                columns: new[] { "AbilityId", "MonsterId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6357), null, null, null, null },
                    { 3, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6376), null, null, null, null },
                    { 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6392), null, null, null, null },
                    { 3, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6409), null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterResistance",
                columns: new[] { "DamageTypeId", "MonsterId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5669), null, null, null, null, 0.0 },
                    { 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5690), null, null, null, null, 0.0 },
                    { 3, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5710), null, null, null, null, 0.0 },
                    { 4, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5728), null, null, null, null, 0.0 },
                    { 5, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5746), null, null, null, null, 0.0 },
                    { 6, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5765), null, null, null, null, 0.0 },
                    { 7, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5783), null, null, null, null, 0.0 },
                    { 8, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5801), null, null, null, null, 0.0 },
                    { 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5820), null, null, null, null, 0.0 },
                    { 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5838), null, null, null, null, 0.0 },
                    { 3, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5855), null, null, null, null, 0.0 },
                    { 4, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5874), null, null, null, null, 0.0 },
                    { 5, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5893), null, null, null, null, 0.0 },
                    { 6, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5912), null, null, null, null, 0.0 },
                    { 7, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5930), null, null, null, null, 0.0 },
                    { 8, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5949), null, null, null, null, 0.0 },
                    { 1, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5966), null, null, null, null, 0.0 },
                    { 2, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5987), null, null, null, null, 0.0 },
                    { 3, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6005), null, null, null, null, 0.0 },
                    { 4, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6023), null, null, null, null, 0.0 },
                    { 5, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6040), null, null, null, null, 0.0 },
                    { 6, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6058), null, null, null, null, 0.0 },
                    { 7, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6092), null, null, null, null, 0.0 },
                    { 8, 3, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6111), null, null, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterResource",
                columns: new[] { "LanguageId", "MonsterId", "ResourceTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5433), null, null, null, null, "Dragón negro" },
                    { 1, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5453), null, null, null, null, "un gran dragón negro" },
                    { 2, 1, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5537), null, null, null, null, "Black Dragon" },
                    { 2, 1, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5554), null, null, null, null, "A great black dragon" },
                    { 1, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5471), null, null, null, null, "Limo" },
                    { 1, 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5487), null, null, null, null, "Una masa que lastima al contacto" },
                    { 2, 2, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5573), null, null, null, null, "Slime" },
                    { 2, 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5591), null, null, null, null, "A mass that hurts on contact" },
                    { 1, 3, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5503), null, null, null, null, "Lobo" },
                    { 1, 3, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5521), null, null, null, null, "Una criatura salvaje" },
                    { 2, 3, 1, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5607), null, null, null, null, "Wolf" },
                    { 2, 3, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(5623), null, null, null, null, "A wild creature" }
                });

            migrationBuilder.InsertData(
                schema: "GAME",
                table: "MonsterZone",
                columns: new[] { "MonsterId", "ZoneId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 2, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6132), null, null, null, null },
                    { 3, 2, "Seed", new DateTime(2023, 11, 26, 18, 25, 34, 568, DateTimeKind.Local).AddTicks(6154), null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_DamageTypeId",
                schema: "GAME",
                table: "Ability",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_SkillId",
                schema: "GAME",
                table: "Ability",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityResource_LanguageId",
                schema: "GAME",
                table: "AbilityResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityResource_ResourceTypeId",
                schema: "GAME",
                table: "AbilityResource",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Battle_ZoneId",
                schema: "GAME",
                table: "Battle",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleAction_AbilityId",
                schema: "GAME",
                table: "BattleAction",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleAction_BattleId",
                schema: "GAME",
                table: "BattleAction",
                column: "BattleId");

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
                name: "IX_CharacterAbility_AbilityId",
                schema: "GAME",
                table: "CharacterAbility",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_ClassId",
                schema: "GAME",
                table: "CharacterAbility",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterResistance_DamageTypeId",
                schema: "GAME",
                table: "CharacterResistance",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_SkillId",
                schema: "GAME",
                table: "CharacterSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassAbility_AbilityId",
                schema: "GAME",
                table: "ClassAbility",
                column: "AbilityId");

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
                name: "IX_MonsterAbility_AbilityId",
                schema: "GAME",
                table: "MonsterAbility",
                column: "AbilityId");

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
                name: "IX_MonsterZone_ZoneId",
                schema: "GAME",
                table: "MonsterZone",
                column: "ZoneId");

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
                name: "AbilityResource",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "BattleActionAffected",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "BattleParticipant",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "CharacterAbility",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "CharacterResistance",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "CharacterSkill",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "ClassAbility",
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
                name: "MonsterAbility",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "MonsterResistance",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "MonsterResource",
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
                name: "Ability",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Battle",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "User",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Creature",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "DamageType",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Skill",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Zone",
                schema: "GAME");

            migrationBuilder.DropTable(
                name: "Class",
                schema: "GAME");
        }
    }
}
