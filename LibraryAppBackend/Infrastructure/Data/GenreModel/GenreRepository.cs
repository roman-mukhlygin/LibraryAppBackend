using LibraryAppBackend.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppBackend.Infrastructure.Data.GenreModel
{
    public class GenreRepository : IGenreRepository
    {
        private readonly LibraryContext _dbContext;
        public GenreRepository( LibraryContext libraryContext )
        {
            _dbContext = libraryContext;
        }

        public List<Genre> GetAll()
        {
            return _dbContext.Genre.Include(genre => genre.Books).ToList();
        }

        public Genre GetByName( string name )
        {
            return _dbContext.Genre.Where( g => g.Name == name ).Single();
        }
    }
}
