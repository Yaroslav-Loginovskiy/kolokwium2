using kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumsController : Controller
    {
        private readonly IMusicDbService _service;

        private AlbumsController(IMusicDbService service)
        {
            _service = service;
        }

        [HttpGet("{idAlbum}")]
        public IActionResult GetAlbum(int idAlbum)
        {
            try
            {
                var response = _service.GetAlbum(idAlbum);
                return Ok(response);
            }
            catch (Exception exc)
            {
                return NotFound(exc.Message);
            }
        }

        [HttpPost]
        public IActionResult DeleteMusician (int idMusician)
        {
            try
            {
                _service.DeleteMusician(idMusician);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }
    }
}
