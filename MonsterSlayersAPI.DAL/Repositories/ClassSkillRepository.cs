using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.DAL.Repositories.Base;
using MonsterSlayersAPI.Security.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.DAL.Repositories
{
    public class ClassSkillRepository : BaseRepository<ClassSkill>, IClassSkillRepository
    {
        public ClassSkillRepository(MonsterSlayersContext context) : base(context) { }
    }
}
