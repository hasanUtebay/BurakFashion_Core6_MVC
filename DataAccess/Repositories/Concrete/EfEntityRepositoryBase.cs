using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class,new()
        where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using (TContext projectContext = new TContext())
            {
                var addedEntity = projectContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                //var table = projectContext.Set<TEntity>();
                //table.Add(entity);
                projectContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext projectContext = new TContext())
            {
                var deletedEntity = projectContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                projectContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext projectContext = new TContext())
            {
                return projectContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext projectContext = new TContext())
            {
                if (filter == null)
                {
                    return projectContext.Set<TEntity>().ToList();
                }
                else
                {
                    return projectContext.Set<TEntity>().Where(filter).ToList();
                }
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext projectContext = new TContext())
            {
                var updatedEntity = projectContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                projectContext.SaveChanges();
            }
        }
    }
}
