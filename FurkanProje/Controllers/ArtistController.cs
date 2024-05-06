using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private IArtistService _artistService;


        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetList()
        {
            var result = _artistService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("GetById")]
        public IActionResult GetById( int Id)
        {
            var result = _artistService.GetById(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Entities.Concrete.Artist artist)
        {
            var result = _artistService.Add(artist);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Entities.Concrete.Artist artist)
        {
            var result = _artistService.Delete(artist);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(Entities.Concrete.Artist artist)
        {
            var result = _artistService.Update(artist);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}