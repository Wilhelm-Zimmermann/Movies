using Movies.Domain.Entities;

namespace Movies.Domain.Repositories
{
    public interface ICategoriesRepository
    {
        Task CreateCategory(Category category);
    }
}
