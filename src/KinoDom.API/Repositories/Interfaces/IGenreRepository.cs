using KinoDom.API.Data.Models;

namespace KinoDom.API.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        Task<List<Genre>> GetAllAsync();
        Task<Genre?> GetByIdAsync(Guid id);
        Task<Genre> CreateAsync(Genre genre);
        Task<Genre?> UpdateAsync(Guid id, Genre genre);
        Task<bool> DeleteAsync(Guid id);
    }
}
