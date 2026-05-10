using KinoDom.API.Data;
using KinoDom.API.Data.Models;
using KinoDom.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KinoDom.API.Repositories.Implementations
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;
        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Movie>> GetAllAsync()
        {
            return await _context.Movies.ToListAsync();
        }
        public async Task<Movie?> GetByIdAsync(Guid id)
        {
            return await _context.Movies.FindAsync(id);
        }
        public async Task<Movie> CreateAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
           
            return movie;
        }
        public async Task<Movie?> UpdateAsync(Guid id, Movie movie)
        {
            var existingMovie = await _context.Movies.FindAsync(id);
         
            if (existingMovie == null)
                return null;
            
            existingMovie.Title = movie.Title;
            existingMovie.Description = movie.Description;
            existingMovie.ReleaseYear = movie.ReleaseYear;
            existingMovie.DurationMinutes = movie.DurationMinutes;
            existingMovie.PosterUrl = movie.PosterUrl;
            existingMovie.TrailerUrl = movie.TrailerUrl;
            
            await _context.SaveChangesAsync();
            
            return existingMovie;
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            var movie = await _context.Movies.FindAsync(id);
            
            if (movie == null)
                return false;
            
            _context.Movies.Remove(movie);
            
            await _context.SaveChangesAsync();
            
            return true;
        }
        }
}
