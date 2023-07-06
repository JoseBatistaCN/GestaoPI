using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Data;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.DAL
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal GestaopiContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(GestaopiContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> Get()
        {
            IQueryable<TEntity> query = dbSet;
            return await query.ToListAsync();
        }

        public virtual async Task<TEntity> GetByID(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task Insert(TEntity entity)
        {
            dbSet.Add(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task Delete(object id)
        {
            TEntity entityToDelete = await dbSet.FindAsync(id);
            Delete(entityToDelete);
            await context.SaveChangesAsync();
        }

        
    }
}