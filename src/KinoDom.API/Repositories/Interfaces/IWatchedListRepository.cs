using KinoDom.API.Data.Models;

namespace KinoDom.API.Repositories.Interfaces
{
    public interface IWatchedListRepository
    {
        Task<List<WatchedList>> GetAllAsync();
        Task<WatchedList?> GetByIdAsync(Guid id);
        Task<WatchedList> CreateAsync(WatchedList watchedList);
        Task<bool> DeleteAsync(Guid id);
    }
}
