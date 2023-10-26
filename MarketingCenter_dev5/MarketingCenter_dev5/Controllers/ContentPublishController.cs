using MarketingCenterData;
using MarketingCenterData.DataBaseContext;
using Microsoft.AspNetCore.Mvc;
using MarketingCenter_dev5.DTI;


namespace MarketingCenter_dev5.Controllers
{
    public class ContentPublishController : Controller
    {
        private readonly IContentPublishDTI _contentPublish;

        public ContentPublishController(ContentPublishDti contentPublish )
        {
            _contentPublish = contentPublish;
        }

        [HttpGet("GetContentPublish")]
        public async Task<IActionResult> GetContentPublish() =>  Ok(await _contentPublish.GetContentPublish());

        [HttpGet("GetContentPublishByCategoryId/{categoryId:int}")]
        public async Task<IActionResult> GetContentPublishedByCategoryId(int categoryId) =>
             Ok(await _contentPublish.GetContentPublishByCategoryId(categoryId));

        [HttpGet("GetContentPublishBySubCategoryId/{subcategoryId:int}")]
        public async Task<IActionResult> GetContentpublishbysubcategoryid(int subcategoryId) => 
            Ok(await _contentPublish.GetContentPublishBySubCategoryId(subcategoryId));

        [HttpGet("GetContentPublishByInteriorSubCategoryId/{interiorsubcategoryId:int}")]
        public async Task<IActionResult> GetContentpublishbyinteriorsubcategoryid(int interiorsubcategoryId) => 
            Ok( await _contentPublish.GetContentPublishByInteriorSubCategoryId(interiorsubcategoryId));

        [HttpPost("PostContentPublish")]
        public async Task<IActionResult> PostContentPublish([FromBody] ContentPublishDTO contentPublish)
        {
            var returnMessage = string.Empty;

            if (ModelState.IsValid)
                returnMessage = await _contentPublish.SaveContentPublish(contentPublish);

            if (returnMessage.Contains("Success"))
                return Ok(returnMessage);
            else
                return BadRequest(returnMessage);
            
        }

        [HttpGet("getmediatypes")]
        public IActionResult GetMediaTypes()
        {
            var mediatypes = new[]
            {
                new {id = 1, name = "No Multimedia"},
                new {id = 2, name = "Show All"},
                new {id = 3, name = "Video"},
                new {id = 4, name = "Audio"},
                new {id = 5, name = "Video & Audio"}
            };
            return Ok(mediatypes);
        }
    }
}
