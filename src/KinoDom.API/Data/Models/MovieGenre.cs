namespace KinoDom.API.Data.Models
{
    public class MovieGenre
    {
        public Guid MovieId { get; set; }
        public Guid GenreId { get; set; }

        // Navigation properties for the many-to-many relationship
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}