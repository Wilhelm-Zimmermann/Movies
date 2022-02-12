using Movies.Domain.Entities;

namespace Movies.Domain.Repositories
{
    public interface IMoviesRepository
    {
        Task CreateMovie(Movie movie);
        Task UpdateMovie(Movie movie);
        Task DeleteMovie(Movie movie);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieById(Guid id);
        Task<IEnumerable<Movie>> GetMoviesPerCategory(string category);
    }
}
