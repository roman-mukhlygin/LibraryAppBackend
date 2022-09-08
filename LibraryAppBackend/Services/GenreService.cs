using LibraryAppBackend.Dto;
using LibraryAppBackend.Infrastructure.Data.GenreModel;

namespace LibraryAppBackend.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService( IGenreRepository genreRepository )
        {
            _genreRepository = genreRepository;
        }
        public List<GenreDto> GetGenreList()
        {
            return _genreRepository.GetAll().ConvertAll( genre => genre.ConvertToGenreDto() );
        }
    }
}
