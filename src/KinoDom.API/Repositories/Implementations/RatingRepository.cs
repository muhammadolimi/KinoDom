using KinoDom.API.Data;
using KinoDom.API.Data.Models;
using KinoDom.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KinoDom.API.Repositories.Implementations
{
    public class RatingRepository : IRatingRepository
    {
        private readonly ApplicationDbContext _context;

        public RatingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Rating>> GetAllAsync()
        {
            return await _context.Ratings.ToListAsync();
        }

        public async Task<Rating?> GetByIdAsync(Guid id)
        {
            return await _context.Ratings.FindAsync(id);
        }

        public async Task<Rating> CreateAsync(Rating rating)
        {
            await _context.Ratings.AddAsync(rating);
            await _context.SaveChangesAsync();

            return rating;
        }

        public async Task<Rating?> UpdateAsync(Guid id, Rating rating)
        {
            var existingRating = await _context.Ratings.FindAsync(id);


            if (existingRating == null)
                return null;

            existingRating.UserId = rating.UserId;
            existingRating.MovieId = rating.MovieId;
            existingRating.Score = rating.Score;

            await _context.SaveChangesAsync();

            return existingRating;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
                return false;

            _context.Ratings.Remove(rating);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}