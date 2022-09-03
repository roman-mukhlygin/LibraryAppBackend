using LibraryAppBackend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAppBackend.Infrastructure.Data.GenreModel.EntityConfiguration
{
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure( EntityTypeBuilder<Genre> builder )
        {
            builder.HasKey( x => x.Id );
            builder.Property( x => x.Id ).ValueGeneratedOnAdd();
            builder.Property( x => x.Name );
        }
    }
}
