using LibraryAppBackend.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppBackend.Infrastructure.Data.AuthorModel
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _dbContext;
        public AuthorRepository( LibraryContext dbContext )
        {
            _dbContext = dbContext;
        }

        public List<Author> GetAll()
        {
            return _dbContext.Author.Include( author => author.Books ).ToList();
        }

        public Author GetByName( string name )
        {
            return _dbContext.Author.Where( x => x.Name == name ).Single();
        }
    }
}
