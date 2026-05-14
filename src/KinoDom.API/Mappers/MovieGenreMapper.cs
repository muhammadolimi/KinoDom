using KinoDom.API.Data.DTOs.MovieGenre;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers
{
    public static class MovieGenreMapper
    {
        public static MovieGenreDto ToDto(this MovieGenre movieGenre)
        {
            return new MovieGenreDto
            {
                MovieId = movieGenre.MovieId,
                GenreId = movieGenre.GenreId
            };
        }
        public static MovieGenre ToEntity(this CreateMovieGenreDto dto)
        {
            return new MovieGenre
            {
                MovieId = dto.MovieId,
                GenreId = dto.GenreId
            };
        }
    }
}