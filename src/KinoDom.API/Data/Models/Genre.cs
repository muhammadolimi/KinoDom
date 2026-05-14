namespace KinoDom.API.Data.Models
{
    public class Genre : BaseEntity
    {
        public String Name { get; set; }

        // Navigation properties
        public ICollection<MovieGenre> MovieGenres { get; set; } = [];
    }
}