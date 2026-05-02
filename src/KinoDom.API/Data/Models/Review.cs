namespace KinoDom.API.Data.Models
{
    public class Review : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid MovieId { get; set; }
        public String Text { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}
