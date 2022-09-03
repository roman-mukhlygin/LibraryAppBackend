using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Data.AuthorModel.EntityConfiguration
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure( EntityTypeBuilder<Author> builder )
        {
            builder.HasKey( x => x.Id );
            builder.Property( x => x.Id ).ValueGeneratedOnAdd();
            builder.Property( x => x.Name );
        }
    }
}
