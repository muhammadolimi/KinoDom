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
                AverageRating = movie.AverageRating
            };
        }
        
        public static MovieDto ToEntity(this CreateMovieDto dto)
        {
            return new MovieDto
            {
                Title = dto.Title,
                ReleaseYear = dto.ReleaseYear,
                DurationMinutes = dto.DurationMinutes,
                PosterUrl = dto.PosterUrl,
                TrailerUrl = dto.TrailerUrl
            };
        }

        public static MovieDto ToEntity(this UpdateMovieDto dto)
        {
            return new MovieDto
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
