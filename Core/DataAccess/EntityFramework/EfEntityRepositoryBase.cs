using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext>(TContext context) : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        return context.Set<TEntity>().SingleOrDefault(filter);
    }

    public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
    {
        return filter == null
            ? context.Set<TEntity>().ToList()
            : context.Set<TEntity>().Where(filter).ToList();
    }

    public void Add(TEntity entity)
    {
        context.Set<TEntity>().Add(entity);
        context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        var deletedEntity = context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        var updatedEntity = context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        context.SaveChanges();
    }

    public IQueryable<TEntity> AsQueryable()
    {
        return context.Set<TEntity>().AsQueryable();
    }
}