using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entities
{
    public class Category : EntityBase
    {
        public string Title { get; private set; }

        public Category(string title)
        {
            Title = title;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}
