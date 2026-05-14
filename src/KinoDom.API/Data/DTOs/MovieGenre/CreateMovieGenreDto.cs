namespace KinoDom.API.Data.DTOs.MovieGenre
{
    public class CreateMovieGenreDto
    {
        public Guid MovieId { get; set; }
        public Guid GenreId { get; set; }
    }
}
