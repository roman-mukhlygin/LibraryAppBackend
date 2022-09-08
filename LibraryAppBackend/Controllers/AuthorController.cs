using LibraryAppBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAppBackend.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController( IAuthorService authorService )
        {
            _authorService = authorService;
        }

        [HttpGet]
        [Route( "list" )]
        public IActionResult GetAuthorList()
        {
            try
            {
                return Ok( _authorService.GetAuthorList() );
            }
            catch ( Exception ex )
            {
                return BadRequest( ex.Message );
            }
        }
    }
}
