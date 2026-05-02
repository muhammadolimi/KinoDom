using KinoDom.API.Data.DTOs.WishList;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers;

public static class WishListMapper
{
    public static WishListDto ToDto(this WatchedList watchedlist)
    {
        return new WishListDto
        {
            Id = watchedlist.Id,
            MovieId = watchedlist.MovieId,
            CreatedAt = watchedlist.CreatedAt
        };
    }

    public static WishList ToEntity(this CreateWishListDto dto, Guid userId)
    {
        return new WishList
        {
            MovieId = dto.MovieId,
            UserId = userId
        };
    }
}
