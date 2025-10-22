using CodePulse.AI.Data;
using CodePulse.AI.Models.Domain;
using CodePulse.AI.Repositories.Interface;

namespace CodePulse.AI.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;    
        }
        public async Task<Category> CreateAsync(Category category)
        {

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;

        }
         
    }
}
