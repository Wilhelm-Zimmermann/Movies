using Movies.Domain.Entities;
using System.Linq.Expressions;

namespace Movies.Domain.Queries
{
    public class MoviesQueries
    {
        public Expression<Func<Movie, bool>> GetMovieById(Guid id)
        {
            return x => x.Id == id;
        }

        public Expression<Func<Movie,bool>> GetMoviesPerCategory(string category)
        {
            return x => x.Category == category;
        }
    }
}
