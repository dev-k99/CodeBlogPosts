using CodePulse.AI.Models.Domain;

namespace CodePulse.AI.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
