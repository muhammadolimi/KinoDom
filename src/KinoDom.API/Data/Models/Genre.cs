namespace KinoDom.API.Data.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        // Navigation property for the many-to-many relationship with Movie
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}