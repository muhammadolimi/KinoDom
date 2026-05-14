using KinoDom.API.Data;
using KinoDom.API.Data.Models;
using KinoDom.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KinoDom.API.Repositories.Implementations
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all reviews
        public async Task<List<Review>> GetAllAsync()
        {
            return await _context.Reviews.ToListAsync();
        }

        // Get a review by ID
        public async Task<Review?> GetByIdAsync(Guid id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        // Create a new review
        public async Task<Review> CreateAsync(Review review)
        {
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();

            return review;
        }

        // Update an existing review
        public async Task<Review?> UpdateAsync(Guid id, Review review)
        {
            var existingReview = await _context.Reviews.FindAsync(id);

            if (existingReview == null)
                return null;

            existingReview.UserId = review.UserId;
            existingReview.MovieId = review.MovieId;
            existingReview.Text = review.Text;

            await _context.SaveChangesAsync();

            return existingReview;
        }

        // Delete a review
        public async Task<bool> DeleteAsync(Guid id)
        {
            var review = await _context.Reviews.FindAsync(id);

            if (review == null)
                return false;

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}