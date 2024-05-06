using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Core.DataAccess.EntityFramework;

public class EfEntityReposityBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    private readonly TContext _context;
    public EfEntityReposityBase()
    {
        _context = new TContext();
    }
    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using (var context = new TContext())
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }
    public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
    {
        using (var context = new TContext())
        {
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }
    }
    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
    }
    public void Delete(TEntity entity)
    {
        var context = new TContext();
        var deletedEntity = context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        context.SaveChanges();
    }
    public void Update(TEntity entity)
    {
        var context = new TContext();
        var updatedEntity = context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        context.SaveChanges();
    }
    public IQueryable<TEntity> AsQueryable()
    {
        return _context.Set<TEntity>().AsQueryable();
    }
}