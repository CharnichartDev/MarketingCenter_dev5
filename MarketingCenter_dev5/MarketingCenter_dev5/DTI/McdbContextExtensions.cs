using MarketingCenterData.DataBaseContext;

namespace MarketingCenter_dev5.DTO
{
    public static class McdbContextExtensions
    {
        public static bool ContentPublishesEmptyOrEmpty(this McdbContext context)
        {
            return context.ContentPublishes == null || !context.ContentPublishes.Any();
        }
    }
}
