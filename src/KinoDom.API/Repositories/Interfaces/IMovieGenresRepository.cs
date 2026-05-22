using KinoDom.API.Data.Models;

namespace KinoDom.API.Repositories.Interfaces
{
    public interface IMovieGenreRepository
    {
        Task<List<MovieGenre>> GetAllAsync();
        Task<List<MovieGenre>> GetByMovieIdAsync(Guid movieId);
        Task<List<MovieGenre>> GetByGenreIdAsync(Guid genreId);
        Task<MovieGenre> CreateAsync(MovieGenre movieGenre);
        Task<bool> DeleteAsync(Guid movieId, Guid genreId);
    }
}
