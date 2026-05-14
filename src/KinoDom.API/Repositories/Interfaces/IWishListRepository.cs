using KinoDom.API.Data.Models;

namespace KinoDom.API.Repositories.Interfaces
{
    public interface IWishListRepository
    {
        Task<List<WishList>> GetAllAsync();
        Task<WishList?> GetByIdAsync(Guid id);
        Task<WishList> CreateAsync(WishList wishList);
        Task<WishList?> UpdateAsync(Guid id, WishList wishList);
        Task<bool> DeleteAsync(Guid id);
    }
}
