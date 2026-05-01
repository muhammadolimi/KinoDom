namespace KinoDom.API.Data.DTOs.Movie
{
    public class CreateMovieDto
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int? DurationMinutes { get; set; }
        public string? PosterUrl { get; set; }
        public string? TrailerUrl { get; set; }
    }
}
