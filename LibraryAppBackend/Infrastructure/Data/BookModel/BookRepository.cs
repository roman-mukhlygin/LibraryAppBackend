using LibraryAppBackend.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppBackend.Infrastructure.Data.BookModel
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _dbContext;
        public BookRepository( LibraryContext dbContext )
        {
            _dbContext = dbContext;
        }
        public int Create( Book book )
        {
            return _dbContext.Book.Add( book ).Entity.Id;
        }

        public void Delete( Book book )
        {
            _dbContext.Book.Remove( book );
        }

        public Book Get( int id )
        {
            return _dbContext.Book.Where( book => book.Id == id ).Include(book => book.Genre).Include( book => book.Author ).SingleOrDefault();
        }

        public List<Book> GetAll()
        {
            return _dbContext.Book.Include( book => book.Genre ).Include( book => book.Author ).ToList();
        }

        public void Update( Book book )
        {
            _dbContext.Book.Update( book );
        }
    }
}
