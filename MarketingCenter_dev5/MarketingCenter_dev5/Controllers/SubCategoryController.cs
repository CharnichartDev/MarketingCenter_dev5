using MarketingCenter_dev5.DTI;
using MarketingCenterData.DataBaseContext;
using Microsoft.AspNetCore.Mvc;

namespace MarketingCenter_dev5.Controllers
{

    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubcategoryDti _subcategory;

        public SubCategoryController(SubcategoryDti subcategoryDti)
        {
            _subcategory = subcategoryDti;
        }


        [HttpGet("GetSubCategories")]
        public async Task<IActionResult> GetSubCategories() => Ok(await _subcategory.GetSubCategories());


        [HttpGet("GetSubCategoryById/{subcategoryId:int}")]
        public async Task<IActionResult> GetSubCategoryById(int subcategoryId) =>
            Ok(await _subcategory.GetSubCategoryById(subcategoryId));


        [HttpPost("SaveSubCategory")]
        public async Task<IActionResult> PostSubCategory([FromBody] SubcategoryDTO subcategory)
        {
            var returnMessage = string.Empty;

            if (ModelState.IsValid)
                returnMessage = await _subcategory.SaveSubCategory(subcategory);

            if (returnMessage.Contains("Success"))
                return Ok(returnMessage);
            else
                return BadRequest(returnMessage);
        }



    }
}
