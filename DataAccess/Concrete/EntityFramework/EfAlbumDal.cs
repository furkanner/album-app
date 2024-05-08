using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfAlbumDal : EfEntityRepositoryBase<Album, FurkanContext>, IAlbumDal
{
    public EfAlbumDal(FurkanContext context) : base(context)
    {
    }
}