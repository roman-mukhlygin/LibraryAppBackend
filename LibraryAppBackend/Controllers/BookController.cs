using LibraryAppBackend.Dto;
using LibraryAppBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAppBackend.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController( IBookService bookService )
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route( "list" )]
        public IActionResult GetBookList()
        {
            try
            {
                return Ok( _bookService.GetBookList() );
            }
            catch ( Exception ex )
            {
                return BadRequest( ex.Message );
            }
        }

        [HttpGet]
        [Route( "{bookId}" )]
        public IActionResult GetBook( int bookId )
        {
            try
            {
                return Ok( _bookService.GetBook( bookId ) );
            }
            catch ( Exception ex )
            {
                return BadRequest( ex.Message );
            }
        }

        [HttpPost]
        public IActionResult CreateBook( BookDto bookDto )
        {
            try
            {
                return Ok( _bookService.CreateBook( bookDto ) );
            }
            catch ( Exception ex )
            {
                return BadRequest( ex.Message );
            }
        }

        [HttpPut]
        public IActionResult UpdateBook( BookDto bookDto )
        {
            try
            {
                _bookService.UpdateBook( bookDto );
                return Ok();
            }
            catch ( Exception ex )
            {
                return BadRequest( ex.Message );
            }
        }

        [HttpDelete]
        [Route( "{bookId}" )]
        public IActionResult DeleteBook( int bookId )
        {
            try
            {
                _bookService.DeleteBook( bookId );
                return Ok();
            }
            catch ( Exception ex )
            {
                return BadRequest( ex.Message );
            }
        }
    }
}
