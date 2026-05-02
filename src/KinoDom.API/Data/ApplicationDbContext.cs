using Microsoft.EntityFrameworkCore;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Data;

public class ApplicationDbContext(DbContextOptions dbContextOptions) :
    DbContext(dbContextOptions)
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}
