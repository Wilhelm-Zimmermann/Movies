namespace Movies.Domain.Entities
{
    public class Movie : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public TimeSpan DurationInMinutes { get; private set; }
        public string Category { get; private set; }
        public int Rate { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Movie(string title, string description, TimeSpan durationInMinutes, string category, int rate)
        {
            Title = title;
            Description = description;
            DurationInMinutes = durationInMinutes;
            Category = category;
            Rate = rate;
            CreatedAt = DateTime.Now;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }

        public void UpdateDuration(TimeSpan durationInMinutes)
        {
            DurationInMinutes = durationInMinutes;
        }

        public void UpdateRate(int rate)
        {
            Rate = rate;
        }
    }
}
