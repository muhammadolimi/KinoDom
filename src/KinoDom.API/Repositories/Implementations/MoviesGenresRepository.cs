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

        public async Task<List<MovieGenre>> GetByMovieIdAsync(Guid movieId)
        {
            return await _context.MovieGenres
                .Where(mg => mg.MovieId == movieId)
                .Include(mg => mg.Genre)
                .ToListAsync();
        }

        public async Task<List<MovieGenre>> GetByGenreIdAsync(Guid genreId)
        {
            return await _context.MovieGenres
                .Where(mg => mg.GenreId == genreId)
                .Include(mg => mg.Movie)
                .ToListAsync();
        }

        public async Task<MovieGenre> CreateAsync(MovieGenre movieGenre)
        {
            await _context.MovieGenres.AddAsync(movieGenre);
            await _context.SaveChangesAsync();
            return movieGenre;
        }

        public async Task<bool> DeleteAsync(Guid movieId, Guid genreId)
        {
            var movieGenre = await _context.MovieGenres
                .FirstOrDefaultAsync(mg => mg.MovieId == movieId && mg.GenreId == genreId);

            if (movieGenre == null)
                return false;

            _context.MovieGenres.Remove(movieGenre);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
