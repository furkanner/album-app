using Core.Utilities.Results;
using Entities.Concrete;
using IResult = Core.Utilities.Results.IResult;


namespace Business.Abstract;

public interface IMusicService
{
    IDataResult<List<Music>> GetList();
    IDataResult<List<Music>> GetListByAlbum(int albumId);
    IDataResult<List<Music>> GetListByArtist(int id);
    IResult Add(Music music);
    IResult Delete(Music music);
    IResult Update(Music music);
}