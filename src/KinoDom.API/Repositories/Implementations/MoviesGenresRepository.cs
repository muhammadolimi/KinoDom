using KinoDom.API.Data;
using KinoDom.API.Data.Models;
using KinoDom.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KinoDom.API.Repositories.Implementations
{
    public class MovieGenreRepository : IMovieGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieGenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<MovieGenre>> GetAllAsync()
        {
            return await _context.MovieGenres
                .Include(mg => mg.Movie)
                .Include(mg => mg.Genre)
                .ToListAsync();
        }

        // Find specific relationship by movieId and genreId (composite key)
        public async Task<MovieGenre?> GetByMovieAndGenreAsync(Guid movieId, Guid genreId)
        {
            return await _context.MovieGenres
                .Include(mg => mg.Movie)
                .Include(mg => mg.Genre)
                .FirstOrDefaultAsync(mg => mg.MovieId == movieId && mg.GenreId == genreId);
        }

        // genres assigned to one movie
        public async Task<List<MovieGenre>> GetByMovieIdAsync(Guid movieId)
        {
            return await _context.MovieGenres
                .Where(mg => mg.MovieId == movieId)
                .Include(mg => mg.Genre)
                .ToListAsync();
        }

        // movies by genre
        public async Task<List<MovieGenre>> GetByGenreIdAsync(Guid genreId)
        {
            return await _context.MovieGenres
                .Where(mg => mg.GenreId == genreId)
                .Include(mg => mg.Movie)
                .ToListAsync();
        }

        // Create new movie-genre relationship
        public async Task<MovieGenre> CreateAsync(MovieGenre movieGenre)
        {
            await _context.MovieGenres.AddAsync(movieGenre);
            await _context.SaveChangesAsync();
           
            return movieGenre;
        }
        public async Task<bool> DeleteAsync(Guid movieId, Guid genreId)
        {
            // Find the relationship to delete
            var movieGenre = await _context.MovieGenres
                .FirstOrDefaultAsync(mg => mg.MovieId == movieId && mg.GenreId == genreId);

            // If not found, return false
            if (movieGenre == null)
                return false;

            // Remove and save
            _context.MovieGenres.Remove(movieGenre);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}