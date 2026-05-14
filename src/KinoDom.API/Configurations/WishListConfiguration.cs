using KinoDom.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging.Abstractions;

namespace KinoDom.API.Configurations
{
    internal class WishListConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => new { x.UserId, x.MovieId })
                .IsUnique();

            builder.HasOne(x => x.Movie)
                .WithMany(x => x.WishLists)
                .HasForeignKey(x => x.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany(x => x.WishLists)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
