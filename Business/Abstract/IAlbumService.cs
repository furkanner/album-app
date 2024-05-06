using Core.Utilities.Results;
using Entities.Concrete;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Abstract
{
    public interface IAlbumService
    { 
        IDataResult<List<Album>> GetList();
        IDataResult<List<Album>> GetListByArtist(int artistId);
        IResult Add(Album album);
        IResult Delete(Album album);
        IResult Update(Album album);
    }
}