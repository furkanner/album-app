using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Concrete;

public class MusicManager : IMusicService

{
    IMusicDal _musicDal;

    public MusicManager(IMusicDal musicDal)
    {
        _musicDal = musicDal;
    }

    public IDataResult<List<Music>> GetList()
    {
        var query = _musicDal.AsQueryable()
            .Include(p => p.Album.Artist)
            .ToList();
        return new SuccessDataResult<List<Music>>(query);
        //return new SuccessDataResult<List<Music>>(_musicDal.GetList().ToList());
    }

    public IDataResult<List<Music>> GetListByAlbum(int albumId)
    {
        var query = _musicDal.AsQueryable()
            .Include(p => p.Album.Artist)
            .Where(p => p.AlbumId == albumId)
            .ToList();
        
        
        return new SuccessDataResult<List<Music>>(query);
    }

    public IResult Add(Music music)
    {
        _musicDal.Add(music);
        return new SuccessResult(Messages.SarkiAdded);
    }

    public IResult Delete(Music music)
    {
        _musicDal.Delete(music);
        return new SuccessResult(Messages.SarkiDeleted);
    }

    public IResult Update(Music music)
    {
        _musicDal.Update(music);
        return new SuccessResult(Messages.SarkiUpdated);
    }
}