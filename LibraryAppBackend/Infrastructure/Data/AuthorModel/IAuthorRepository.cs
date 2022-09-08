using LibraryAppBackend.Domain;

namespace LibraryAppBackend.Infrastructure.Data.AuthorModel
{
    public interface IAuthorRepository
    {
        Author GetByName( string name );
        List<Author> GetAll();
    }
}
