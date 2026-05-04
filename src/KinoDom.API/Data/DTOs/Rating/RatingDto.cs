namespace KinoDom.API.Data.DTOs.Rating
{
    public class RatingDto
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
