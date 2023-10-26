namespace MarketingCenter_dev5.DTI;

public interface ICategoryDTI
{
    Task<string> GetCategories();
    Task<string> GetCategoryById(int categoryId);
    Task<string> SaveCategory(CategoryDTO category);
    Task<string> SeedCategories();
}