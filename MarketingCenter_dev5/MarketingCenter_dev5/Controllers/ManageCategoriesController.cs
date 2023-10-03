using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarketingCenterData.DataBaseContext;
using Serilog;
using MarketingCenterData;


namespace MarketingCenter_dev5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageCategoriesController : ControllerBase
    {
        private readonly ILogger<ManageCategoriesController> _logger;
        private readonly McdbContext _context;

        public ManageCategoriesController(ILogger<ManageCategoriesController> logger, McdbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("getcategories")]
        public IActionResult GetCategories()
        {
                var categories = _context.Categories;
                return Ok(categories);
        }


        [HttpGet("getsubcategories")]
        public IActionResult GetSubCategories()
        {
            var subcategories = from c in _context.Categories
                                join subCat in _context.Subcategories on c.CategoryId equals subCat.CategoryId
                                select new
                                {
                                    categoryId = subCat.CategoryId,
                                    subcategoryId = subCat.SubcategoryId,
                                    name = subCat.Name,
                                    catLandingDescription = subCat.CatLandingDescription,
                                    Headline = subCat.Headline,
                                    catLandingDescriptionMarkup = subCat.CatLandingDescriptionMarkup,
                                    descriptionMarkup = subCat.DescriptionMarkup,
                                    externalUrlActive = subCat.ExternalUrlActive,
                                    prettyUrl = subCat.PrettyUrl,
                                    externalUrl = subCat.ExternalUrl,
                                    fileOrig = subCat.FileOrig,
                                    estatic = subCat.Static
                                };
            return Ok(subcategories);
        }

        [HttpGet("getsubcategoriesbycategoryid/{categoryId:int}")]
        public IActionResult GetSubCategoriesByCategoryId(int categoryId)
        {
            var subcategories = from c in _context.Categories
                                join subCat in _context.Subcategories on c.CategoryId equals subCat.CategoryId
                                where c.CategoryId == categoryId
                                select new
                                {
                                    categoryId = subCat.CategoryId,
                                    subcategoryId = subCat.SubcategoryId,
                                    name = subCat.Name,
                                    catLandingDescription = subCat.CatLandingDescription,
                                    headline = subCat.Headline,
                                    catLandingDescriptionMarkup = subCat.CatLandingDescriptionMarkup,
                                    descriptionMarkup = subCat.DescriptionMarkup,
                                    externalUrlActive = subCat.ExternalUrlActive,
                                    prettyUrl = subCat.PrettyUrl,
                                    externalUrl = subCat.ExternalUrl,
                                    fileOrig = subCat.FileOrig,
                                    estatic = subCat.Static
                                };
            return Ok(subcategories);
        }

        [HttpPost("postsubcategory")]
        public IActionResult PostSubCategory(Subcategory subcategory)
        {
            try
            {
                _context.Subcategories.Add(subcategory);
                _context.SaveChanges();
                return Ok(subcategory);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error {ex.Message}");
            }
        }

        [HttpGet("getinteriorsubcategoriesbysubcategoryid/{subcategoryId:int}")]
        public IActionResult GetInteriorSubCategoriesBySubCategoryId(int subcategoryId)
        {
            var interiorSubCategories = from subCat in _context.Subcategories
                                        join interiorSubCat in _context.InteriorSubCategories on subCat.SubcategoryId equals interiorSubCat.SubcategoryId
                                        where subCat.SubcategoryId == subcategoryId
                                        select new
                                        {
                                            subcategoryId = interiorSubCat.SubcategoryId,
                                            interiorsubcategoryId = interiorSubCat.InteriorsubcategoryId,
                                            name = interiorSubCat.Name,
                                            catLandingDescription = interiorSubCat.CatLandingDescription,
                                            headline = interiorSubCat.Headline,
                                            catLandingDescriptionMarkup = interiorSubCat.CatLandingDescriptionMarkup,
                                            descriptionMarkup = interiorSubCat.DescriptionMarkup,
                                            externalUrlActive = interiorSubCat.ExternalUrlActive,
                                            prettyUrl = interiorSubCat.PrettyUrl,
                                            externalUrl = interiorSubCat.ExternalUrl,
                                            fileOrig = interiorSubCat.FileOrig,
                                            estatic = interiorSubCat.Static
                                        };
            return Ok(interiorSubCategories);
        }

        [HttpPost("postinteriorsubcategory")]
        public IActionResult PostInteriorSubCategory(InteriorSubCategory interiorSubCategory)
        {
            try
            {
                _context.InteriorSubCategories.Add(interiorSubCategory);
                _context.SaveChanges();
                return Ok(interiorSubCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error {ex.Message}");
            }
        }











    }
}
