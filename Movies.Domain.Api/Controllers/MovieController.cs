using Microsoft.AspNetCore.Mvc;
using Movies.Domain.Commands;
using Movies.Domain.Handlers;

namespace Movies.Domain.Api.Controllers
{
    [ApiController]
    [Route("movies/new")]
    public class MovieController : ControllerBase
    {
        [HttpPost]
        public async Task<GenericCommandResult> CreateMovie([FromBody] CreateMovieCommand command, [FromServices] MovieHandler handler)
        {
            var handle = (GenericCommandResult) await handler.Handle(command);
            return handle;
        }
    }
}
