using KinoDom.API.Data.DTOs.Rating;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers
{
    public static class RatingMapper
    {
        public static RatingDto ToDto(this Rating rating)
        {
            return new RatingDto
            {
                Id = rating.Id,
                MovieId = rating.MovieId,
                Score = rating.Score
            };
        }

        public static Rating ToEntity(this CreateRatingDto dto)
        {
            return new Rating
            {
                MovieId = dto.MovieId,
                Score = dto.Score
            };
        }

        public static Rating ToEntity(this UpdateRatingDto dto)
        {
            return new Rating
            {
                Score = dto.Score
            };
        }
    }
}
