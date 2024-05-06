using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.Contants;
using Microsoft.EntityFrameworkCore;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Concrete
{
    public class AlbumManager : IAlbumService
    {
        private readonly IAlbumDal _albumDal;

        public AlbumManager(IAlbumDal albumDal)
        {
            _albumDal = albumDal;
        }

        public IDataResult<List<Album>> GetList()
        {
            var query = _albumDal.AsQueryable()
                .Include(p => p.Artist)
                .ToList();

            return new SuccessDataResult<List<Album>>(query);
        }

        public IDataResult<List<Album>> GetListByArtist(int artistId)
        {
            var query = _albumDal.AsQueryable()
                .Include(p=>p.Artist)
                .Where(a => a.ArtistId == artistId)
                .ToList();

            return new SuccessDataResult<List<Album>>(query);
        }

        public IResult Add(Album album)
        {
            _albumDal.Add(album);
            return new SuccessResult(Messages.AlbumAdded);
        }

        public IResult Delete(Album album)
        {
            _albumDal.Delete(album);
            return new SuccessResult(Messages.AlbumDeleted);
        }

        public IResult Update(Album album)
        {
            _albumDal.Update(album);
            return new SuccessResult(Messages.AlbumUpdated);
        }
    }
}