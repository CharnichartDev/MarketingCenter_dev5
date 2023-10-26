namespace MarketingCenter_dev5.DTI;

public interface ISubcategoryDti
{
    Task<string> GetSubCategories();
    Task<string> GetSubCategoryById(int subcategoryId);
    Task<string> SaveSubCategory(SubcategoryDTO subcategory);
}