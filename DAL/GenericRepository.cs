using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GestaoPI.DAL;
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
        /*
            This method is used to get all records from the database.
        */
        public virtual async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            // includeProperties will be comma delimited
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }


            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            } else
            {
                return await query.ToListAsync();
            }

        }

        public virtual async Task<TEntity?> GetByID(object id)
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
            TEntity? entityToDelete = await dbSet.FindAsync(id);
            if (entityToDelete != null)
                Delete(entityToDelete);
        }
        public virtual void Delete(TEntity entityToDelete) 
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate) 
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

    }
}