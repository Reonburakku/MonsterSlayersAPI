using Microsoft.EntityFrameworkCore;
using MonsterSlayers.Security.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayers.Security.DAL.Data
{
    public partial class MonsterSlayersSecurityContext : DbContext
    {
        public MonsterSlayersSecurityContext()
        {
        }

        public MonsterSlayersSecurityContext(DbContextOptions<MonsterSlayersSecurityContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Comercios { get; set; }

        public virtual DbSet<Role> Enumeracions { get; set; }

        public virtual DbSet<UserRole> Servicios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:AsignacionTurnosAsesoft");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK_User");

                entity.ToTable("User");

                entity.Property(e => e.UserName).HasColumnName("UserName");
                entity.Property(e => e.Password).HasMaxLength(100).IsUnicode(false).HasColumnName("Password");
                entity.Property(e => e.Email).HasMaxLength(100).IsUnicode(false).HasColumnName("Email");
                entity.Property(e => e.CreationDate).HasMaxLength(100).IsUnicode(false).HasColumnName("CreationDate");
                entity.Property(e => e.LastLoginDate).HasMaxLength(100).IsUnicode(false).HasColumnName("LastLoginDate");
                entity.Property(e => e.ModificationDate).HasMaxLength(100).IsUnicode(false).HasColumnName("ModificationDate");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleId).HasName("PK_RoleId");

                entity.ToTable("Role");

                entity.Property(e => e.Name).ValueGeneratedNever().HasColumnName("id_enumeracion");

            });

            modelBuilder.Entity<UserRole>(entity =>
            {

                entity.ToTable("UserRole");

                entity.Property(e => e.UserId).HasColumnName("UserId");
                entity.Property(e => e.RoleId).HasColumnName("duracion");

                entity.HasOne<User>(e => e.User).WithMany(x => x.UserRoles)
                    .HasForeignKey(e => e.UserId)
                    .HasConstraintName("FK_UserRoleUser");
                entity.HasOne<Role>(e => e.Role).WithMany(x => x.UserRoles)
                    .HasForeignKey(e => e.RoleId)
                    .HasConstraintName("FK_RoleRoleUser");
            });
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Role>().HasData(new Role { RoleId = 1, Name = "admin" });
        //}
    }
}
