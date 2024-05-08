using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfArtistDal : EfEntityRepositoryBase<Artist, FurkanContext>, IArtistDal
{
    public EfArtistDal(FurkanContext context) : base(context)
    {
    }
}