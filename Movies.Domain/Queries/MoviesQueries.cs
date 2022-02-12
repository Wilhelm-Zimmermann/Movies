using Movies.Domain.Entities;
using System.Linq.Expressions;

namespace Movies.Domain.Queries
{
    public static class MoviesQueries
    {
        public static Expression<Func<Movie, bool>> GetMovieById(Guid id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Movie,bool>> GetMoviesPerCategory(string category)
        {
            return x => x.Category == category;
        }
    }
}
