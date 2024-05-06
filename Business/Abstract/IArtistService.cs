using Core.Utilities.Results;
using Entities.Concrete;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Abstract;

public interface IArtistService
{
    //IDataResult<Artist> GetById(int ArtistId);
    IDataResult<Artist> GetById(int Id);//Ekledim

    IDataResult<List<Artist>> GetList();
    IResult Add(Artist artist);
    IResult Delete(Artist artist);
    IResult Update(Artist artist);
}