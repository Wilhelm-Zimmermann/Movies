using Microsoft.AspNetCore.Mvc;
using Movies.Domain.Commands;
using Movies.Domain.Entities;
using Movies.Domain.Handlers;
using Movies.Domain.Repositories;

namespace Movies.Domain.Api.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        [HttpPost]
        [Route("new")]
        public async Task<GenericCommandResult> CreateMovie([FromForm] CreateMovieCommand command, [FromServices] MovieHandler handler)
        {
            var handle = (GenericCommandResult) await handler.Handle(command);
            return handle;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> GetMovies([FromServices] IMoviesRepository repository)
        {
            return await repository.GetMovies();
        }
    }
}
