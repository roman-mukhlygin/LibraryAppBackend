using Library.Domain;

namespace Library.Infrastructure.Data.GenreModel
{
    public interface IGenreRepository
    {
        Genre GetByName( string name );
    }
}
