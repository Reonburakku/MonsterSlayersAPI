using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MonsterSlayersAPI.BLL.Enumerations;
using MonsterSlayersAPI.BLL.Interfaces.Repositories.Base;
using MonsterSlayersAPI.Security.DAL.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.DAL.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public MonsterSlayersContext context;
        public DbSet<TEntity> dbSet;
        public LanguageEnum language;
        public string source;

        public BaseRepository(MonsterSlayersContext context, string source)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
            this.source = source;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbSet.ToArrayAsync();
        }

        public async ValueTask<TEntity> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        //public async Task<IEnumerable<TEntity>> GetByIdRangeAsync(IEnumerable<int> values)
        //{
        //    var t = typeof(TEntity);
        //    var id = t.GetProperty("Id");
        //    var a = dbSet.First();
        //    var aid = id.GetValue(a);

        //    return await dbSet.Where(x => values.Contains((int)id.GetValue(x))).ToArrayAsync();
        //}

        public async Task<TEntity> Save(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            context.SaveChanges(source);
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            dbSet.Update(entity);
            context.SaveChanges(source);
            return entity;
        }
    }
}
