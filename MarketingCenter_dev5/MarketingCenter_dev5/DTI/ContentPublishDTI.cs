using MarketingCenter_dev5.Controllers;
using MarketingCenterData;
using MarketingCenterData.DataBaseContext;
using Newtonsoft.Json;

namespace MarketingCenter_dev5.DTI
{
    public class ContentPublishDti : IContentPublishDTI
    {
        private readonly McdbContext _context;
        private readonly ILogger<ContentPublishController> _logger;

        public ContentPublishDti(McdbContext context, ILogger<ContentPublishController> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<string> GetContentPublish() => await Task.Run(() =>
            {
                var json = string.Empty;
                var contextContentPublishes = _context.ContentPublishes;
                if (contextContentPublishes == null || !contextContentPublishes.Any()) return string.Empty;
                var contentPublishes = _context.ContentPublishes!.ToList();
                json = JsonConvert.SerializeObject(contentPublishes);
                return json;
            });


        public async Task<string> GetContentPublishByCategoryId(int categoryId) => await Task.Run(() =>
        {
            var json = string.Empty;
            var contextContentPublishes = _context.ContentPublishes!.Where(c => c.CategoryIdw == categoryId);
            if (!contextContentPublishes.Any()) return string.Empty;
            var contentPublishes = contextContentPublishes.ToList();
            json = JsonConvert.SerializeObject(contentPublishes);
            return json;
        });

        public async Task<string> GetContentPublishBySubCategoryId(int subcategoryId) => await Task.Run(() =>
        {
            var json = string.Empty;
            var contextContentPublishes = _context.ContentPublishes!.Where(c => c.SubcategoryIdw == subcategoryId);
            if (!contextContentPublishes.Any()) return string.Empty;
            var contentPublishes = contextContentPublishes.ToList();
            json = JsonConvert.SerializeObject(contentPublishes);
            return json;
        });

        public async Task<string> GetContentPublishByInteriorSubCategoryId(int interiorSubcategoryId) => await Task.Run(() =>
        {
            var json = string.Empty;
            var contextContentPublishes = _context.ContentPublishes!.Where(c => c.InteriorSubcategoryIdw == interiorSubcategoryId);
            if (!contextContentPublishes.Any()) return string.Empty;
            var contentPublishes = contextContentPublishes.ToList();
            json = JsonConvert.SerializeObject(contentPublishes);
            return json;
        });

        public async Task<string> SaveContentPublish(ContentPublishDTO contentPublish)
        {
            var json = string.Empty;

            try
            {
                _context.ContentPublishes!.Add(contentPublish);
                await _context.SaveChangesAsync();
                json = JsonConvert.SerializeObject(new { ErrStatusor = "Success" });
                _logger.LogInformation("ContentPublish Saved Successfully");
            }
            catch (Exception ex)
            {

                json = JsonConvert.SerializeObject(new { ErrStatusor = "Error" });
                _logger.LogError(ex.Message);
            }

            return json;

        }



    }
}
