using Flunt.Notifications;
using Flunt.Validations;
using Movies.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Commands
{
    public class CreateMovieCommand : Contract<CreateMovieCommand>, ICommand
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
            Requires()
                .IsNotNullOrEmpty(Title, "Title", "Title cannot be null")
                .IsNotNullOrEmpty(Description, "Description", "Description Cannot be null")
                .IsGreaterThan(0, Rate, "Rate Cannot be null");
        }
    }
}
