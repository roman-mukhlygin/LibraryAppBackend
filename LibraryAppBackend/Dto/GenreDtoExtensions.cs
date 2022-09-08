using LibraryAppBackend.Domain;

namespace LibraryAppBackend.Dto
{
    public static class GenreDtoExtensions
    {
        public static GenreDto ConvertToGenreDto( this Genre genre )
        {
            return new GenreDto
            {
                Id = genre.Id,
                Name = genre.Name,
            };
        }
    }
}
