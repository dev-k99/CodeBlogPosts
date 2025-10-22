using CodePulse.AI.Data;
using CodePulse.AI.Models.Domain;
using CodePulse.AI.Models.DTO;
using CodePulse.AI.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.AI.Controllers
{

    //https://localhost:xxx/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
           this.categoryRepository= categoryRepository;
        }
        //
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            //Map DTO to Domain Model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

          
            await categoryRepository.CreateAsync(category);

            //Domain model to Dto
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);


        }

    }
}
