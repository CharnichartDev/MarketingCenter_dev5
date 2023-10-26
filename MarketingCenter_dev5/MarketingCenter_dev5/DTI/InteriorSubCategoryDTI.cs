using MarketingCenter_dev5.Controllers;
using MarketingCenterData;
using MarketingCenterData.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MarketingCenter_dev5.DTI
{
    public class InteriorSubCategoryDti : IInteriorSubCategoryDti
    {
        private readonly McdbContext _context;
        private readonly ILogger<InteriorSubCategoryController> _logger;

        public InteriorSubCategoryDti(McdbContext context, ILogger<InteriorSubCategoryController> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<string> GetInteriorSubCategories() => await Task.Run(() =>
        {
            var json = string.Empty;

            try
            {
                var contextInteriorSubCategories = _context.InteriorSubCategories;
                if (contextInteriorSubCategories == null || !contextInteriorSubCategories.Any()) return string.Empty;
                var interiorSubCategories = _context.InteriorSubCategories!.ToList();
                json = JsonConvert.SerializeObject(interiorSubCategories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return json;
        });


        public async Task<string> GetInteriorSubCategoryById(int interiorSubcategoryId) => await Task.Run(() =>
        {
            var json = string.Empty;

            try
            {
                var contextInteriorSubCategories = _context.InteriorSubCategories!.Where(c => c.InteriorSubCategoryId == interiorSubcategoryId);
                if (!contextInteriorSubCategories.Any()) return string.Empty;
                var interiorSubCategories = contextInteriorSubCategories.ToList();
                json = JsonConvert.SerializeObject(interiorSubCategories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return json;
        });


        public async Task<string> SaveInteriorSubCategory(InteriorSubCategoryDTO interiorSubcategory)
        {
            var returnMessage = string.Empty;

            try
            {
                var contextSubCategories = _context.Subcategories!.Where(c => c.SubcategoryId == interiorSubcategory.InteriorSubCategoryId);
                if (contextSubCategories.Any())
                {
                    returnMessage = "Interior Subcategory already exists";
                }
                else
                {
                    _context.InteriorSubCategories!.Add(interiorSubcategory);
                    await _context.SaveChangesAsync();
                    returnMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return returnMessage;
        }



    }
}
