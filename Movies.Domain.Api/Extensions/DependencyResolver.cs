using Movies.Domain.Handlers;
using Microsoft.EntityFrameworkCore;
using Movies.Domain.Handlers.Contracts;
using Movies.Domain.Infra.Contexts;
using Movies.Domain.Repositories;
using Movies.Domain.Infra.Repositories;

namespace Movies.Domain.Api.Extensions
{
    public static class DependencyResolver
    {
        public static void ResolveDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<MovieContext>(opt => opt.UseInMemoryDatabase("Database"));
            builder.Services.AddScoped<MovieHandler, MovieHandler>();
            builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();
        }
    }
}
