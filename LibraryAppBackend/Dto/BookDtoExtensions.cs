using Library.Domain;

namespace Library.Dto
{
    public static class BookDtoExtensions
    {
        public static Book ConvertToBook( this BookDto bookDto, int genreId, int authorId )
        {
            return new Book
            {
                Id = bookDto.Id,
                Name = bookDto.Name,
                Year = bookDto.Year,
                GenreId = genreId,
                AuthorId = authorId
            };
        }

        public static BookDto ConvertToBookDto( this Book book, string genre, string author )
        {
            return new BookDto
            {
                Id = book.Id,
                Name = book.Name,
                Year = book.Year,
                Genre = genre,
                Author = author
            };
        }
    }
}
