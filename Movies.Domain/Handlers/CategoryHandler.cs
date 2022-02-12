using Movies.Domain.Commands;
using Movies.Domain.Commands.Contracts;
using Movies.Domain.Entities;
using Movies.Domain.Handlers.Contracts;
using Movies.Domain.Repositories;

namespace Movies.Domain.Handlers
{
    public class CategoryHandler : IHandler<CreateCategoryCommand>
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoryHandler(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public async Task<ICommandResult> Handle(CreateCategoryCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult("Invalid Category", false, command.Notifications);

            var category = new Category(command.Title);

            await _categoriesRepository.CreateCategory(category);

            return new GenericCommandResult("Category created successfully", true, category); 
        }
    }
}
