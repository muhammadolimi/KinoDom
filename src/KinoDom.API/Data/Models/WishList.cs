namespace KinoDom.API.Data.Models
{
    public class WishList : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }

        // Navigation properties 
        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
