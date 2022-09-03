using LibraryAppBackend.Domain;

namespace LibraryAppBackend.Infrastructure.Data.GenreModel
{
    public interface IGenreRepository
    {
        Genre GetByName( string name );
    }
}
