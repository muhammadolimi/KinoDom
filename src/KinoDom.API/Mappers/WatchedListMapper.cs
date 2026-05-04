using KinoDom.API.Data.DTOs.WatchedList;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers;

public static class WatchedListMapper
{
    public static WatchedListDto ToDto(this WatchedList watchedlist)
    {
        return new WatchedListDto
        {
            Id = watchedlist.Id,
            MovieId = watchedlist.MovieId,
            CreatedAt = watchedlist.CreatedAt
        };
    }

    public static WatchedList ToEntity(this CreateWatchedListDto dto, Guid userId)
    {
        return new WatchedList
        {
            MovieId = dto.MovieId,
            CreatedAt = DateTime.UtcNow
        };
    }
}
