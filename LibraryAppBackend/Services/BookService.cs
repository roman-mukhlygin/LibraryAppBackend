using Library.Domain;
using Library.Dto;
using Library.Infrastructure.Data.AuthorModel;
using Library.Infrastructure.Data.BookModel;
using Library.Infrastructure.Data.GenreModel;
using Library.Infrastructure.UoW;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public BookService( IBookRepository bookRepository, IGenreRepository genreRepository, IAuthorRepository authorRepository, IUnitOfWork unitOfWork )  
        {
            _bookRepository = bookRepository;
            _genreRepository = genreRepository;
            _authorRepository = authorRepository;
            _unitOfWork = unitOfWork;
        }

        public int CreateBook( BookDto bookDto )
        {
            if ( bookDto == null )
            {
                throw new Exception( $"{nameof( bookDto )} not found" );
            };

            Book book = bookDto.ConvertToBook( _genreRepository.GetByName( bookDto.Genre ).Id, _authorRepository.GetByName( bookDto.Author ).Id );

            int id = _bookRepository.Create( book );
            _unitOfWork.SaveEntitiesAsync();

            return id;
        }

        public void DeleteBook( int id )
        {
            Book book = _bookRepository.Get( id );
            if ( book == null )
            {
                throw new Exception( $"{nameof( book )} not found, #Id - {id}" );
            }

            _bookRepository.Delete( book );
            _unitOfWork.SaveEntitiesAsync();
        }

        public BookDto GetBook( int id )
        {
            Book book = _bookRepository.Get( id );
            if ( book == null )
            {
                throw new Exception( $"{nameof( book )} not found, #Id - {id}" );
            }
            BookDto bookDto = book.ConvertToBookDto( book.Genre.Name, book.Author.Name );

            return bookDto;
        }

        public List<BookDto> GetBookList()
        {
            return _bookRepository.GetAll().ConvertAll( book => book.ConvertToBookDto( book.Genre.Name, book.Author.Name ) );
        }

        public void UpdateBook( BookDto bookDto )
        {
            Book book = _bookRepository.Get( bookDto.Id );
            if ( book == null )
            {
                throw new Exception( $"{nameof( book )} not found, #Id - {bookDto.Id}" );
            }

            Book bookEntity = bookDto.ConvertToBook( _genreRepository.GetByName(bookDto.Genre).Id, _authorRepository.GetByName(bookDto.Author).Id );
            
            book.Name = bookEntity.Name;
            book.Year = bookEntity.Year;
            book.GenreId = bookEntity.GenreId;
            book.AuthorId = bookEntity.AuthorId;

            _unitOfWork.SaveEntitiesAsync();
        }
    }
}
