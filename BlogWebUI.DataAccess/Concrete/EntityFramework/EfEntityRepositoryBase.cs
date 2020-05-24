using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.DataAccess.Abstract;
using BlogWebUI.Entities.Abstract;

namespace BlogWebUI.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TContext, TEntity> : IEntityRepository<TEntity>
    where TEntity : class, IDatabaseEntity, new()
    where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var usedEntity = context.Entry(entity);
                usedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var usedEntity = context.Entry(entity);
                usedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter==null 
                    ? context.Set<TEntity>().ToList() 
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var usedEntity = context.Entry(entity);
                usedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
