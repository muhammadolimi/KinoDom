using KinoDom.API.Data.DTOs.Genre;
using KinoDom.API.Data.Models;

public static class GenreMapper
{
    public static Genre ToEntity(CreateGenreDto dto)
    {
        return new Genre
        {
            Name = dto.Name
        };
    }

    public static GenreDto ToDto(Genre genre)
    {
        return new GenreDto
        {
            Id = genre.Id,
            Name = genre.Name
        };
    }
}