using LibraryAppBackend.Domain;
using LibraryAppBackend.Dto;

namespace LibraryAppBackend.Services
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
