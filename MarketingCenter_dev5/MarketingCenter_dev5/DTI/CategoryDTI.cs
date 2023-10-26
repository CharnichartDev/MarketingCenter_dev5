using MarketingCenter_dev5.Controllers;
using MarketingCenterData;
using MarketingCenterData.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MarketingCenter_dev5.DTI
{

    public class CategoryDti : ICategoryDTI
    {
        private McdbContext _context ;
        private readonly ILogger<CategoryDti> _logger;


       public CategoryDti(McdbContext context, ILogger<CategoryDti>  logger )
       {
           _context = context;
           _logger = logger;
       }

        public async Task<string> GetCategories() => await Task.Run(() =>
         {
             var json = string.Empty;
             try
             {
                 var contextCategories = _context.Categories;
                 if (contextCategories == null || !contextCategories.Any()) return string.Empty;
                 var categories = _context.Categories!.ToList();
                 json = JsonConvert.SerializeObject(categories);

                 _logger.LogInformation("GetCategories() called");
             }
             catch (Exception ex)
             {
                 _logger.LogError(ex.Message);
             }
             return json;
         });

        public async Task<string> GetCategoryById(int categoryId) => await Task.Run(() =>
        {
            var json = string.Empty;

            try
            {
                var contextCategories = _context.Categories!.Where(c => c.CategoryId == categoryId);
                if (!contextCategories.Any()) return string.Empty;
                var categories = contextCategories.ToList();
                json = JsonConvert.SerializeObject(categories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return json;
        });


        public async Task<string> SaveCategory(CategoryDTO category)
        {
            var returnMessage = string.Empty;

            try
            {
                var contextCategories = _context.Categories!.Where(c => c.CategoryId == category.CategoryId);
                if (contextCategories.Any())
                {
                    returnMessage = "Category already exists";
                }
                else
                {
                    _context.Categories!.Add(category);
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

        public async Task<string> SeedCategories()
        {
            var returnMessage = string.Empty;

            try
            {
                var contextCategories = _context.Categories;
                if (contextCategories == null || !contextCategories.Any())
                {
                    _context.Categories!.Add(new Category { CategoryName = "Marketing" });
                    _context.Categories!.Add(new Category { CategoryName = "Products" });
                    _context.Categories!.Add(new Category { CategoryName = "Interiors" });
                    await _context.SaveChangesAsync();
                    returnMessage = "Success";
                }
                else
                {
                    returnMessage = "Categories already exist";
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
