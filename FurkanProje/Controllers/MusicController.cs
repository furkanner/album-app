using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController(IMusicService musicService, IMusicDal musicDal) : ControllerBase
    {
        private IMusicService _musicService = musicService;
        private IMusicDal _musicDal = musicDal;

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _musicService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("GetListByAlbum")]
        public IActionResult GetListByAlbum(int albumId)
        {
            var result = _musicService.GetListByAlbum(albumId);
            if (result.Success)
            {
                return Ok(new SuccessDataResult<List<Music>>(result.Data));
            }
            else
            {
                return BadRequest(new ErrorDataResult<List<Music>>("Album not found for the given Name"));
            }
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Music music)
        {
            var result = _musicService.Add(music);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Music music)
        {
            var result = _musicService.Delete(music);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(Music music)
        {
            var result = _musicService.Update(music);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}