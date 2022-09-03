using Library.Domain;

namespace Library.Infrastructure.Data.AuthorModel
{
    public interface IAuthorRepository
    {
        Author GetByName( string name );
    }
}
