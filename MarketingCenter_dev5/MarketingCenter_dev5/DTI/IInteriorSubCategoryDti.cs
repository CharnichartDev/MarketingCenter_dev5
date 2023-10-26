namespace MarketingCenter_dev5.DTI;

public interface IInteriorSubCategoryDti
{
    Task<string> GetInteriorSubCategories();
    Task<string> GetInteriorSubCategoryById(int interiorSubcategoryId);
    Task<string> SaveInteriorSubCategory(InteriorSubCategoryDTO interiorSubcategory);
}