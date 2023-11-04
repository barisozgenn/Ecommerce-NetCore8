using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> // We have provided names and descriptions for the <TEntity, TContext> parameters.
    where TEntity : class, new() // Using 'where,' we indicated that TEntity is a class and can be instantiated.
    where TContext : DbContext, new() // Using 'where,' we specified that TContext is derived from DbContext and can be instantiated.

    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {

                var addedEntity = context.Entry(entity: entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        //if we did not make it generic
        /*
        public void Add(TEntity entity : User user)
        {
            using (var context = new BarContextDb))
            context Users Add (user);
            context SaveChanges;
        }*/
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {

                var addedEntity = context.Entry(entity: entity);
                addedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {

                var addedEntity = context.Entry(entity: entity);
                addedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

