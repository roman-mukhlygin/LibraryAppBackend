using Library.Domain;

namespace Library.Infrastructure.Data.AuthorModel
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _dbContext;
        public AuthorRepository( LibraryContext dbContext )
        {
            _dbContext = dbContext;
        }
        public Author GetByName( string name )
        {
            return _dbContext.Author.Where( x => x.Name == name ).Single();
        }
    }
}
