using Microsoft.EntityFrameworkCore.Query.Internal;

namespace KinoDom.API.Data.DTOs.Review
{
    public class ReviewDto
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public String Text { get; set; }
    }
}
