using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Security.DAL.Data
{
    public class MonsterSlayersSecurityContext : IdentityDbContext<IdentityUser>
    {
        public MonsterSlayersSecurityContext(DbContextOptions<MonsterSlayersSecurityContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("SEC");
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Player", NormalizedName= "Player" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "Admin", NormalizedName = "Admin" });
        }
    }
}
