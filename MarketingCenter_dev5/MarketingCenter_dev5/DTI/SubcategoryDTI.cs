using MarketingCenter_dev5.Controllers;
using MarketingCenterData.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MarketingCenter_dev5.DTI
{
    public class SubcategoryDti : ISubcategoryDti
    {
        private readonly McdbContext _context;
        private readonly ILogger<SubCategoryController> _logger;

        public SubcategoryDti(McdbContext context, ILogger<SubCategoryController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<string> GetSubCategories() => await Task.Run(() =>
        {
            var json = string.Empty;

            try
            {
                var contextSubCategories = _context.Subcategories;
                if (contextSubCategories == null || !contextSubCategories.Any()) return string.Empty;
                var subCategories = _context.Subcategories!.ToList();
                json = JsonConvert.SerializeObject(subCategories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return json;
        });

        public async Task<string> GetSubCategoryById(int subcategoryId) => await Task.Run(() =>
        {
            var json = string.Empty;

            try
            {
                var contextSubCategories = _context.Subcategories!.Where(c => c.SubcategoryId == subcategoryId);
                if (!contextSubCategories.Any()) return string.Empty;
                var subCategories = contextSubCategories.ToList();
                json = JsonConvert.SerializeObject(subCategories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return json;
        });


        public async Task<string> SaveSubCategory(SubcategoryDTO subcategory)
        {
            var returnMessage = string.Empty;

            try
            {
                var contextSubCategories = _context.Subcategories!.Where(c => c.SubcategoryId == subcategory.SubcategoryId);
                if (contextSubCategories.Any())
                {
                    returnMessage = "Subcategory already exists";
                }
                else
                {
                    _context.Subcategories!.Add(subcategory);
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
