using Movies.Domain.Entities;
using Movies.Domain.Infra.Contexts;
using Movies.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Movies.Domain.Queries;

namespace Movies.Domain.Infra.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MovieContext _movieContext;

        public MoviesRepository(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task CreateMovie(Movie movie)
        {
            _movieContext.Movies.Add(movie);
            await _movieContext.SaveChangesAsync();
        }

        public async Task DeleteMovie(Movie movie)
        {
            _movieContext.Movies.Remove(movie);
            await _movieContext.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieById(Guid id)
        {
            return await _movieContext.Movies.FirstOrDefaultAsync(MoviesQueries.GetMovieById(id));
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _movieContext.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesPerCategory(string category)
        {
            return await _movieContext.Movies.Where(MoviesQueries.GetMoviesPerCategory(category)).ToListAsync();
        }

        public async Task UpdateMovie(Movie movie)
        {
            _movieContext.Entry(movie).State = EntityState.Modified;
            await _movieContext.SaveChangesAsync();
        }
    }
}
