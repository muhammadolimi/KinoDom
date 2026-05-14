using KinoDom.API.Data;
using KinoDom.API.Data.Models;
using KinoDom.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KinoDom.API.Repositories.Implementations
{
    public class WishListRepository : IWishListRepository
    {
        private readonly ApplicationDbContext _context;
        public WishListRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<WishList>> GetAllAsync()
        {
            return await _context.WishLists.ToListAsync();
        }
        public async Task<WishList?> GetByIdAsync(Guid id)
        {
            return await _context.WishLists.FindAsync(id);
        }
        public async Task<WishList> CreateAsync(WishList wishList)
        {
            await _context.WishLists.AddAsync(wishList);
            await _context.SaveChangesAsync();

            return wishList;
        }
        public async Task<WishList?> UpdateAsync(Guid id, WishList wishList)
        {
            var existingWishList = await _context.WishLists.FindAsync(id);

            if (existingWishList == null)
                return null;
            
            existingWishList.MovieId = wishList.MovieId;
            existingWishList.UserId = wishList.UserId;
            
            await _context.SaveChangesAsync();
            
            return existingWishList;
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            var wishList = await _context.WishLists.FindAsync(id);
            if (wishList == null)
                return false;
            _context.WishLists.Remove(wishList);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
