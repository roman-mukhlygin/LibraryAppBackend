using LibraryAppBackend.Dto;

namespace LibraryAppBackend.Services
{
    public interface IGenreService
    {
        List<GenreDto> GetGenreList();
    }
}
