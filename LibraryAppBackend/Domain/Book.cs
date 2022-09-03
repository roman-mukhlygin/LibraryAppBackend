namespace LibraryAppBackend.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }

        public Genre Genre { get; set; }
        public Author Author { get; set; }
    }
}
