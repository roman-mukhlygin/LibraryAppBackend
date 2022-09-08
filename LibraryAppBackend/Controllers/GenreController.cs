using LibraryAppBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAppBackend.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenreController( IGenreService genreService )    
        {
            _genreService = genreService;
        }

        [HttpGet]
        [Route( "list" )]
        public IActionResult GetGenreList()
        {
            try
            {
                return Ok( _genreService.GetGenreList() );
            }
            catch ( Exception ex )
            {
                return BadRequest( ex.Message );
            }
        }
    }
}
