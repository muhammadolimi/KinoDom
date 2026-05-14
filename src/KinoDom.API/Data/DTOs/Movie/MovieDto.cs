namespace KinoDom.API.Data.DTOs.Movie
{
    public class MovieDto
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public int ReleaseYear { get; set; }
        public int? DurationMinutes { get; set; }
        public String? PosterUrl { get; set; }
        public String? TrailerUrl { get; set; }
        public float? AverageRating { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
