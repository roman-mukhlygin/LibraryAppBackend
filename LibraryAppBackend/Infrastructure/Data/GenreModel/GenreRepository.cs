using LibraryAppBackend.Domain;

namespace LibraryAppBackend.Infrastructure.Data.GenreModel
{
    public class GenreRepository : IGenreRepository
    {
        private readonly LibraryContext _dbContext;
        public GenreRepository( LibraryContext libraryContext )
        {
            _dbContext = libraryContext;
        }
        public Genre GetByName( string name )
        {
            return _dbContext.Genre.Where( g => g.Name == name ).Single();
        }
    }
}
