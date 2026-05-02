namespace KinoDom.API.Data.DTOs.Rating
{
    public class CreateRatingDto
    {
        public Guid MovieId { get; set; }
        public int Score { get; set; }
    }
}
