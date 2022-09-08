using LibraryAppBackend.Dto;
using LibraryAppBackend.Infrastructure.Data.AuthorModel;

namespace LibraryAppBackend.Services
{
    public class AuthorService : IAuthorService

    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService( IAuthorRepository authorRepository )
        {
            _authorRepository = authorRepository;
        }
        public List<AuthorDto> GetAuthorList()
        {
            return _authorRepository.GetAll().ConvertAll( author => author.ConvertToAuthorDto() );
        }
    }
}
