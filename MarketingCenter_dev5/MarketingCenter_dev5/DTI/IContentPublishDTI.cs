namespace MarketingCenter_dev5.DTI;

public interface IContentPublishDTI
{
    Task<string> GetContentPublish();
    Task<string> GetContentPublishByCategoryId(int categoryId);
    Task<string> GetContentPublishBySubCategoryId(int subcategoryId);
    Task<string> GetContentPublishByInteriorSubCategoryId(int interiorSubcategoryId);
    Task<string> SaveContentPublish(ContentPublishDTO contentPublish);
}