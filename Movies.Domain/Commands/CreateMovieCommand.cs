using Flunt.Notifications;
using Flunt.Validations;
using Movies.Domain.Commands.Contracts;

namespace Movies.Domain.Commands
{
    public class CreateMovieCommand : Notifiable, ICommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan DurationInMinutes { get; set; }
        public string Category { get; set; }
        public int Rate { get; set; }

        public CreateMovieCommand(string title, string description, TimeSpan durationInMinutes, string category, int rate)
        {
            Title = title;
            Description = description;
            DurationInMinutes = durationInMinutes;
            Category = category;
            Rate = rate;
        }

        public CreateMovieCommand()
        {

        }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Title, 3, "CreateMovieCommand.Title", "Title must contain at least 3 caracteres")
                .HasMinLen(Description, 10, "CreateMovieCommand.Description", "Description must contain at least 10 caracteres")
                .IsGreaterThan(Rate, 0, "CreateMovieCommand.Rate", "Rate must be above 0"));
        }
    }
}
