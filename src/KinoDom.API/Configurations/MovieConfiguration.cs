using KinoDom.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KinoDom.API.Configurations
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Description)
                 .HasMaxLength(255);

            builder.Property(x => x.ReleaseYear)
                .IsRequired();

            builder.Property(x => x.PosterUrl)
                .HasMaxLength(255);

            builder.Property(x => x.TrailerUrl)
                .HasMaxLength(255);
        }
    }
}