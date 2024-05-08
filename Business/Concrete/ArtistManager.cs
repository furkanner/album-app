using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Concrete;

public class ArtistManager : IArtistService
{
    private readonly IArtistDal _artistDal;

    public ArtistManager(IArtistDal artistDal)
    {
        _artistDal = artistDal;
    }

    public IDataResult<List<Artist>> GetList()
    {
        return new SuccessDataResult<List<Artist>>(_artistDal.GetList().ToList());
    }

    public IDataResult<Artist> GetById(int id)
    {
        return new SuccessDataResult<Artist>(_artistDal.Get(p => p.Id == id));
    }

    public IResult Add(Artist artist)
    {
        _artistDal.Add(artist);
        return new SuccessResult(Messages.ArtistAdded);
    }

    public IResult Delete(Artist artist)
    {
        _artistDal.Delete(artist);
        return new SuccessResult(Messages.ArtistDeleted);
    }

    public IResult Update(Artist artist)
    {
        _artistDal.Update(artist);
        return new SuccessResult(Messages.ArtistUpdated);
    }
}