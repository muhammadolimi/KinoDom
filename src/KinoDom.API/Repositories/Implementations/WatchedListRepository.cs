using KinoDom.API.Data;
using KinoDom.API.Data.Models;
using KinoDom.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KinoDom.API.Repositories.Implementations

{
    public class WatchedListRepository : IWatchedListRepository
    {
        private readonly ApplicationDbContext _context;

        public WatchedListRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<WatchedList>> GetAllAsync()
        {
            return await _context.WatchedLists.ToListAsync();
        }

        public async Task<WatchedList?> GetByIdAsync(Guid id)
        {
            return await _context.WatchedLists.FindAsync(id);
        }

        public async Task<WatchedList> CreateAsync(WatchedList watchedList)
        {
            await _context.WatchedLists.AddAsync(watchedList);
            await _context.SaveChangesAsync();

            return watchedList;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var watchedList = await _context.WatchedLists.FindAsync(id);

            if (watchedList == null)
                return false;

            _context.WatchedLists.Remove(watchedList);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
