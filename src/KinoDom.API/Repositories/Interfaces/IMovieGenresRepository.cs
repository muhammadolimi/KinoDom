using KinoDom.API.Data.Models;

namespace KinoDom.API.Repositories.Interfaces
{
    public interface IMovieGenreRepository
    {
        // Get all movie-genre relations 
        Task<List<MovieGenre>> GetAllAsync();

        // Get specific movie-genre pair by both IDs
        Task<MovieGenre?> GetByMovieAndGenreAsync(Guid movieId, Guid genreId);

        // Genres for a specific movie
        Task<List<MovieGenre>> GetByMovieIdAsync(Guid movieId);

        // Movies for a specific genre
        Task<List<MovieGenre>> GetByGenreIdAsync(Guid genreId);

        // New movie-genre relation
        Task<MovieGenre> CreateAsync(MovieGenre movieGenre);

        // Remove specific relations by both id
        Task<bool> DeleteAsync(Guid movieId, Guid genreId);
    }
}