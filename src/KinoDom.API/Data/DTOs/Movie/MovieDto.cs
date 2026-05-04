namespace KinoDom.API.Data.DTOs.Movie
{
    public class MovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int? DurationMinutes { get; set; }
        public string? PosterUrl { get; set; }
        public string? TrailerUrl { get; set; }
        public float? AverageRating { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
