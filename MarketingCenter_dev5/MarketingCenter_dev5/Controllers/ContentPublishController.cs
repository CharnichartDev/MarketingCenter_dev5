using MarketingCenterData;
using MarketingCenterData.DataBaseContext;
using Microsoft.AspNetCore.Mvc;

namespace MarketingCenter_dev5.Controllers
{
    public class ContentPublishController : Controller
    {
        private readonly ILogger<ManageCategoriesController> _logger;
        private readonly McdbContext _context;

        public ContentPublishController(ILogger<ManageCategoriesController> logger, McdbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("getcontentpublish")]
        public async Task<IActionResult> GetContentPublish() => Ok(_context.ContentPublishes);

        [HttpGet("getcontentpublishbycategoryid/{categoryId:int}")]
        public async Task<IActionResult> GetContentPublishedByCategoryId(int categoryId) =>
             Ok(_context.ContentPublishes!.Where(c => c.CategoryIdw == categoryId));

        [HttpGet("getcontentpublishbysubcategoryid/{subcategoryId:int}")]
        public async Task<IActionResult> GetContentpublishbysubcategoryid(int subcategoryId) => 
            Ok(_context.ContentPublishes!.Where(c => c.SubcategoryIdw == subcategoryId));

        [HttpGet("getcontentpublishbyinteriorsubcategoryid/{interiorsubcategoryId:int}")]
        public async Task<IActionResult> GetContentpublishbyinteriorsubcategoryid(int interiorsubcategoryId) => 
            Ok(_context.ContentPublishes!.Where(c => c.InteriorSubcategoryIdw == interiorsubcategoryId));


        [HttpPost("postcontentpublish")]
        public async Task<IActionResult> PostContentPublish([FromBody] ContentPublish contentPublish)
        {
            if (ModelState.IsValid)
            {
                _context.ContentPublishes!.Add(contentPublish);
                await _context.SaveChangesAsync();
                return Ok(contentPublish);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("putcontentpublish")]
        public async Task<IActionResult> PutContentPublish([FromBody] ContentPublish contentPublish)
        {
            if (ModelState.IsValid)
            {
                _context.ContentPublishes!.Update(contentPublish);
                await _context.SaveChangesAsync();
                return Ok(contentPublish);
            }
            return BadRequest(ModelState);
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
