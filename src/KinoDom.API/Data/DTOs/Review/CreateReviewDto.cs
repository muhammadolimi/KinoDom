using System.Security.Cryptography.X509Certificates;

namespace KinoDom.API.Data.DTOs.Review
{
    public class CreateReviewDto
    {
        public Guid MovieId { get; set; }
        public String Text { get; set; }

    }
}
