using KinoDom.API.Data.Models;

namespace KinoDom.API.Repositories.Interfaces
{
    public interface IRatingRepository
    {
        Task<List<Rating>> GetAllAsync();
        Task<Rating?> GetByIdAsync(Guid id);
        Task<Rating> CreateAsync(Rating rating);
        Task<Rating?> UpdateAsync(Guid id, Rating rating);
        Task<bool> DeleteAsync(Guid id);
    }
}
