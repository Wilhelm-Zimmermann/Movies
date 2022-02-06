using Movies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Repositories
{
    public interface IMoviesRepository
    {
        Task CreateMovie(Movie movie);
        Task UpdateMovie(Movie movie);
        Task DeleteMovie(Movie movie);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieById(Guid id);
        Task<Movie> GetMoviesPerCategory(string category);
    }
}
