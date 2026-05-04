using KinoDom.API.Data.DTOs.Genre;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers
{
    public static class GenreMapper
    {
        public static GenreDto ToDto(this Genre genre)
        {
            return new GenreDto
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }

        public static Genre ToEntity(this CreateGenreDto dto)
        {
            return new Genre
            {
                Name = dto.Name
            };
        }

        public static Genre ToEntity(this UpdateGenreDto dto)
        {
            return new Genre
            {
                Name = dto.Name
            };
        }
    }
}