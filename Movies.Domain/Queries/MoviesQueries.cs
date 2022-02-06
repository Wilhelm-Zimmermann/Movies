using Movies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
