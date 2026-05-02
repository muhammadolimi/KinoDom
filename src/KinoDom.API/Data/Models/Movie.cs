namespace KinoDom.API.Data.Models
{
    public class Movie : BaseEntity
    {
        public String Title { get; set; }
        public int ReleaseYear { get; set; }
        public int? DurationMinutes { get; set; }
        public String? PosterUrl { get; set; }
        public String? TrailerUrl { get; set; }
        public float? AverageRating { get; set; }

        // Navigation properties
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<WatchedList> WatchedLists { get; set; }

    }
}
