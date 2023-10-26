using MarketingCenter_dev5.DTI;
using MarketingCenterData.DataBaseContext;
using MarketingCenterData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketingCenter_dev5.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryDti _category;

        public CategoryController(CategoryDti category)
        {
            _category = category;
        }


        [HttpGet("Seed-Categories")]
        public async Task<IActionResult> SeedCategories()
        {
            var returnMessage = await _category.SeedCategories();
            return Ok(returnMessage);
        }

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories() => Ok(await _category.GetCategories());

        [HttpGet("GetContentPublishbyCategoryid/{categoryId:int}")]
        public async Task<IActionResult> GetContentPublishedByCategoryId(int categoryId) =>
            Ok(await _category.GetCategoryById(categoryId));

        [HttpPost("SaveCategory")]
        public async Task<IActionResult> PostCategory([FromBody] CategoryDTO category)
        {
            var returnMessage = string.Empty;

            if (ModelState.IsValid)
                returnMessage = await _category.SaveCategory(category);

            if (returnMessage.Contains("Success"))
                return Ok(returnMessage);
            else
                return BadRequest(returnMessage);
        }


    }
}
