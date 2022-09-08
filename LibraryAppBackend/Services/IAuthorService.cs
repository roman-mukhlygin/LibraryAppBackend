using LibraryAppBackend.Dto;

namespace LibraryAppBackend.Services
{
    public interface IAuthorService
    {
        List<AuthorDto> GetAuthorList();
    }
}
