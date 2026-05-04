using KinoDom.API.Data.DTOs.Movie;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers
{
    public static class MovieMapper
    {
        public static MovieDto ToDto(this Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                ReleaseYear = movie.ReleaseYear,
                DurationMinutes = movie.DurationMinutes,
                PosterUrl = movie.PosterUrl,
                TrailerUrl = movie.TrailerUrl,
                AverageRating = movie.AverageRating,
                CreatedAt = movie.CreatedAt
            };
        }

        public static Movie ToEntity(this CreateMovieDto dto)  // Fixed: now returns Movie
        {
            return new Movie
            {
                Title = dto.Title,
                ReleaseYear = dto.ReleaseYear,
                DurationMinutes = dto.DurationMinutes,
                PosterUrl = dto.PosterUrl,
                TrailerUrl = dto.TrailerUrl
            };
        }

        public static Movie ToEntity(this UpdateMovieDto dto)  // Fixed: now returns Movie
        {
            return new Movie
            {
                Title = dto.Title,
                ReleaseYear = dto.ReleaseYear,
                DurationMinutes = dto.DurationMinutes,
                PosterUrl = dto.PosterUrl,
                TrailerUrl = dto.TrailerUrl
            };
        }
    }
}
