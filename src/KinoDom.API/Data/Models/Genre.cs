namespace KinoDom.API.Data.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        // Navigation properties
        public ICollection<MovieGenre> MovieGenres { get; set; } = [];
    }
}