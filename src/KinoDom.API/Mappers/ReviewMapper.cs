using KinoDom.API.Data.DTOs.Review;
using KinoDom.API.Data.Models;

namespace KinoDom.API.Mappers
{
    public static class ReviewMapper
    {
        public static ReviewDto ToDto(this Review review) { 
            return new ReviewDto
            {
                Id = review.Id,
                MovieId = review.MovieId,
                Text = review.Text,
                CreatedAt = review.CreatedAt
            };
        }

        public static Review ToEntity(this CreateReviewDto dto)
        {
            return new Review
            {
                MovieId = dto.MovieId,
                Text = dto.Text,
                CreatedAt = DateTime.UtcNow
            };
        }

        public static Review ToEntity(this UpdateReviewDto dto)
        {
            return new Review
            {
                Text = dto.Text
            };
        }
    }
}
