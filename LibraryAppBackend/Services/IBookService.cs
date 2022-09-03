using Library.Domain;
using Library.Dto;

namespace Library.Services
{
    public interface IBookService
    {
        List<BookDto> GetBookList();
        BookDto GetBook( int id );
        void UpdateBook( BookDto bookDto );
        int CreateBook( BookDto bookDto );
        void DeleteBook( int id );
    }
}
