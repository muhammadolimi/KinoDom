namespace KinoDom.API.Data.Models
{
    public class Rating : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid MovieId { get; set; }
        public int Score { get; set; }

        // navigation properties
        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}
