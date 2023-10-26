using MarketingCenter_dev5.DTI;
using MarketingCenterData.DataBaseContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketingCenter_dev5.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class InteriorSubCategoryController : ControllerBase
    {
        private readonly IInteriorSubCategoryDti _interiorSubCategoryDti;

        public InteriorSubCategoryController(InteriorSubCategoryDti interiorSubCategory)
        {
            _interiorSubCategoryDti = interiorSubCategory;
        }

        // get all interior subcategories
        [HttpGet("GetInteriorSubCategories")]
        public async Task<IActionResult> GetInteriorSubCategories() => Ok(await _interiorSubCategoryDti.GetInteriorSubCategories());

        // get interior subcategory by id
        [HttpGet("GetInteriorSubCategoryById/{interiorSubcategoryId:int}")]
        public async Task<IActionResult> GetInteriorSubCategoryById(int interiorSubcategoryId) =>
            Ok(await _interiorSubCategoryDti.GetInteriorSubCategoryById(interiorSubcategoryId));

        // save interior subcategory
        [HttpPost("SaveInteriorSubCategory")]
        public async Task<IActionResult> PostInteriorSubCategory([FromBody] InteriorSubCategoryDTO interiorSubcategory)
        {
            var returnMessage = string.Empty;

            if (ModelState.IsValid)
                returnMessage = await _interiorSubCategoryDti.SaveInteriorSubCategory(interiorSubcategory);

            if (returnMessage.Contains("Success"))
                return Ok(returnMessage);
            else
                return BadRequest(returnMessage);
        }




    }
}
