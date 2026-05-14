using KinoDom.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KinoDom.API.Configurations
{
    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable(x =>
            {
                x.HasCheckConstraint(
                    "CK_Rating_Score",
                    "\"Score\" >= 1 AND \"Score\" <= 10");
            });

            builder.HasOne(r => r.Movie)
                .WithMany(m => m.Ratings)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
