using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Concrete;

public class ArtistManager : IArtistService
{
    private IArtistDal _artistDal;

    public ArtistManager(IArtistDal artistDal)
    {
        _artistDal = artistDal;
    }

    public IDataResult<Artist> GetById(int Id)
    {
        return new SuccessDataResult<Artist>(_artistDal.Get(p => p.Id == Id));
    } //Sanatci_Id idi Id ile değiştirdim.

    public IDataResult<List<Artist>> GetList()
    {
        return new SuccessDataResult<List<Artist>>(_artistDal.GetList().ToList());
    }


    public IResult Add(Artist artist)
    {
        _artistDal.Add(artist);
        return new SuccessResult(Messages.SanatciAdded);
    }

    public IResult Delete(Artist artist)
    {
        _artistDal.Delete(artist);
        return new SuccessResult(Messages.SanatciDeleted);
    }

    public IResult Update(Artist artist)
    {
        _artistDal.Update(artist);
        return new SuccessResult(Messages.SanatciUpdated);
    }
}