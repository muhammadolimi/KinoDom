using KinoDom.API.Data;
using KinoDom.API.Data.Models;
using KinoDom.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KinoDom.API.Repositories.Implementations
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // CRUD operations for Genre

        // Get all genres
        public async Task<List<Genre>> GetAllAsync()
        {
            return await _context.Genres.ToListAsync();
        }

        // Get a genre by ID
        public async Task<Genre?> GetByIdAsync(Guid id)
        {
            return await _context.Genres.FindAsync(id);
        }

        // Create a new genre
        public async Task<Genre> CreateAsync(Genre genre)
        {
            // Add the new genre to the context and save changes
            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();

            return genre;
        }

        // Update an existing genre
        public async Task<Genre?> UpdateAsync(Guid id, Genre genre)
        {
            var existingGenre = await _context.Genres.FindAsync(id);

            // If the genre doesn't exist, return null
            if (existingGenre == null)
                return null;

            // If exists, update the name and save
            existingGenre.Name = genre.Name;

            await _context.SaveChangesAsync();

            return existingGenre;
        }

        // Delete a genre
        public async Task<bool> DeleteAsync(Guid id)
        {
            var genre = await _context.Genres.FindAsync(id);

            // If the genre doesn't exist, return false
            if (genre == null)
                return false;

            // Remove the genre from the context and save changes
            _context.Genres.Remove(genre);

            await _context.SaveChangesAsync();

            return true;
        }
    }

}
