using KinoDom.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KinoDom.API.Configurations
{
    internal class WatchedListConfiguration : IEntityTypeConfiguration<WatchedList>
    {
        public void Configure(EntityTypeBuilder<WatchedList> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Movie)
                .WithMany(m => m.WatchedLists)
                .HasForeignKey(x => x.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany(u => u.WatchedLists)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
