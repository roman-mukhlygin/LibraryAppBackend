using LibraryAppBackend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAppBackend.Infrastructure.Data.BookModel.EntityConfiguration
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure( EntityTypeBuilder<Book> builder )
        {
            builder.HasKey( x => x.Id );
            builder.Property( x => x.Id ).ValueGeneratedOnAdd();
            builder.Property( x => x.Name );
            builder.Property( x => x.Year );
            builder.Property( x => x.GenreId );
            builder.Property( x => x.AuthorId );

            builder.HasOne( x => x.Genre ).WithMany( y => y.Books ).HasForeignKey( x => x.GenreId ).OnDelete( DeleteBehavior.Cascade );
            builder.HasOne( x => x.Author ).WithMany( y => y.Books ).HasForeignKey( x => x.AuthorId ).OnDelete( DeleteBehavior.Cascade );
        }
    }
}
