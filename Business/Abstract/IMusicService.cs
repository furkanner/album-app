using Core.Utilities.Results;
using Entities.Concrete;
using IResult = Core.Utilities.Results.IResult;


namespace Business.Abstract;

public interface IMusicService
{
    IDataResult<List<Music>> GetList();
    //IDataResult<List<Music>> GetListBySarki(string Name);
    IDataResult<List<Music>> GetListByAlbum(int albumId);



    IResult Add(Music music);

    IResult Delete(Music music);

    IResult Update(Music music);
}