using Library.Domain;
using Library.Infrastructure.Data.AuthorModel.EntityConfiguration;
using Library.Infrastructure.Data.BookModel.EntityConfiguration;
using Library.Infrastructure.Data.GenreModel.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext( DbContextOptions<LibraryContext> options ) : base( options )
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public async Task<bool> SaveEntitiesAsync()
        {
            await SaveChangesAsync();
            return true;
        }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating( builder );
            builder.ApplyConfiguration( new BookMap() );
            builder.ApplyConfiguration( new GenreMap() );
            builder.ApplyConfiguration( new AuthorMap() );
        }
    }
}
