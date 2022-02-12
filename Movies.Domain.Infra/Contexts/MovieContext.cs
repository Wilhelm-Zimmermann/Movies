using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entities;

namespace Movies.Domain.Infra.Contexts
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Datya");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Movie>().Property(x => x.Id);
            model.Entity<Movie>().Property(x => x.Title).HasMaxLength(50).HasColumnType("varchar");
            model.Entity<Movie>().Property(x => x.Description).HasMaxLength(250).HasColumnType("varchar");
            model.Entity<Movie>().Property(x => x.DurationInMinutes).HasColumnType("int");
            model.Entity<Movie>().Property(x => x.Category).HasColumnType("varchar");
            model.Entity<Movie>().Property(x => x.Rate).HasColumnType("int");
        }
    }
}
