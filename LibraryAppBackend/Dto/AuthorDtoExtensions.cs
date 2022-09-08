using LibraryAppBackend.Domain;

namespace LibraryAppBackend.Dto
{
    public static class AuthorDtoExtensions
    {
        public static AuthorDto ConvertToAuthorDto( this Author author )
        {
            return new AuthorDto
            {
                Id = author.Id,
                Name = author.Name,
            };
        }
    }
}
