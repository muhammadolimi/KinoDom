using KinoDom.API.Data.DTOs.WishList;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers;

public static class WishListMapper
{
    public static WishListDto ToDto(this WishList wishList)
    {
        return new WishListDto
        {
            Id = wishList.Id,
            MovieId = wishList.MovieId,
            CreatedAt = wishList.CreatedAt
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
