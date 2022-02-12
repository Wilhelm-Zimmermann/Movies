using Movies.Domain.Commands;
using Movies.Domain.Commands.Contracts;
using Movies.Domain.Entities;
using Movies.Domain.Handlers.Contracts;
using Movies.Domain.Repositories;

namespace Movies.Domain.Handlers
{
    public class MovieHandler : IHandler<CreateMovieCommand>
    {
        private readonly IMoviesRepository _repository;

        public MovieHandler(IMoviesRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICommandResult> Handle(CreateMovieCommand command)
        {
            // Verifing if command is valid
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult("Command is invalid", false, command.Notifications);

            // Generate movie
            var movie = new Movie(command.Title, command.Description, command.DurationInMinutes, command.Category, command.Rate);

            // Insert movie in database
            await _repository.CreateMovie(movie);

            // Return success result
            return new GenericCommandResult("Movie created successfully", true, movie);
        }
    }
}
