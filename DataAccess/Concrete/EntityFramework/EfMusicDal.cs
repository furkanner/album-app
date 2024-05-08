using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework;

public class EfMusicDal : EfEntityRepositoryBase<Music, FurkanContext>, IMusicDal
{
    public EfMusicDal(FurkanContext context) : base(context)
    {
    }
}