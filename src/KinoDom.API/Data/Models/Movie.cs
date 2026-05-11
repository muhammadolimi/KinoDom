namespace KinoDom.API.Data.Models
{
    public class Movie : BaseEntity
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public int ReleaseYear { get; set; }
        public int? DurationMinutes { get; set; }
        public String? PosterUrl { get; set; }
        public String? TrailerUrl { get; set; }
        public float? AverageRating { get; set; }

        // Navigation properties
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<Rating> Ratings { get; set; } = [];
        public ICollection<WishList> WishLists { get; set; } = [];
        public ICollection<MovieGenre> MovieGenres { get; set; } = [];
        public ICollection<WatchedList> WatchedLists { get; set; } = [];

    }
}
