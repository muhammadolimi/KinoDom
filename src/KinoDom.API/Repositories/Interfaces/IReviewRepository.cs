using KinoDom.API.Data.Models;

namespace KinoDom.API.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetAllAsync();
        Task<Review?> GetByIdAsync(Guid id);
        Task<Review> CreateAsync(Review review);
        Task<Review?> UpdateAsync(Guid id, Review review);
        Task<bool> DeleteAsync(Guid id);
    }
}
