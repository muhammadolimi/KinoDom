using KinoDom.API.Data.DTOs.Movie;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers
{
    public static class MovieMapper
    {
        public static Movie ToEntity(CreateMovieDto dto)
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

        public static Movie ToDto(Movie movie)
        {
            return new Movie
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
    }
}
