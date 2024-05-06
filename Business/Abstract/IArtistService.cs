using Core.Utilities.Results;
using Entities.Concrete;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Abstract;

public interface IArtistService
{
    IDataResult<List<Artist>> GetList();
    IDataResult<Artist> GetById(int Id);
    IResult Add(Artist artist);
    IResult Delete(Artist artist);
    IResult Update(Artist artist);
}