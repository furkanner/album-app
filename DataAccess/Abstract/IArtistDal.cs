using System.Linq.Expressions;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IArtistDal : IEntityRepository<Artist>
{
    // temel veri ileitisim kodları olacak. ekleme güncelleme silme operasyonları...
}

public interface IEntityRepository<T>
{
    IList<T> GetList(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);

    IQueryable<T> AsQueryable();

    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}