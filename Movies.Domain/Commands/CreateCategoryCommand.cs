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
    public class CreateCategoryCommand : Notifiable, ICommand
    {
        public string Title { get; set; }

        public CreateCategoryCommand()
        {

        }
        public CreateCategoryCommand(string title)
        {
            Title = title;
        }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Title, 3, "Category.Title", "Category min len is 3");
        }
    }
}
