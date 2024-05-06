using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutoBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArtistManager>().As<IArtistService>();
            builder.RegisterType<EfArtistDal>().As<IArtistDal>();

            builder.RegisterType<AlbumManager>().As<IAlbumService>();
            builder.RegisterType<EfAlbumDal>().As<IAlbumDal>();

            builder.RegisterType<MusicManager>().As<IMusicService>();
            builder.RegisterType<EfMusicDal>().As<IMusicDal>();
        }
    }
}