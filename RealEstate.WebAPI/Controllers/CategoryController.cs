using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Entities.Models;
using RealEstate.WebAPI.Models.Categories.RequestModels;
using RealEstate.WebAPI.Models.Categories.ResponseModels;

namespace RealEstate.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestModel item)
        {
            Category c = new()
            {
                Name = item.Name,
                Description = item.Description
            };

            string result = _categoryManager.Add(c);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            List<CategoryResponseModel> categories = _categoryManager.Select(x => new CategoryResponseModel
            {
                Name = x.Name,
                Description = x.Description,
                CategoryId = x.Id
            }).ToList();

            return Ok(categories);
        }
    }
}
