using KinoDom.API.Data.DTOs.Review;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.ExpressionTranslators.Internal;
using System.Runtime.CompilerServices;
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
                Text = review.Text
            };
        }

        public static Review ToEntity(this CreateReviewDto dto)
        {
            return new Review
            {
                MovieId = dto.MovieId,
                Text = dto.Text
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
