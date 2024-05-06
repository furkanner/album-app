using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        public AlbumController(IAlbumService albumService, IAlbumDal albumDal)
        {
            _albumService = albumService;
            _albumDal = albumDal;
        }

        private readonly IAlbumService _albumService;
        private readonly IAlbumDal _albumDal;


        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _albumService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("GetListByArtist")]
        public IActionResult GetListByArtist(int artistId)
        {
            var result = _albumService.GetListByArtist(artistId);
            if (result.Success)
            {
                return Ok(new SuccessDataResult<List<Album>>(result.Data));
            }
            else
            {
                return BadRequest(new ErrorDataResult<List<Album>>("Album not found for the given Name"));
            }
        }

        [HttpPost("Add")]
        public IActionResult Add(Album album)
        {
            var result = _albumService.Add(album);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Album album)
        {
            var result = _albumService.Delete(album);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(Album album)
        {
            var result = _albumService.Update(album);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}