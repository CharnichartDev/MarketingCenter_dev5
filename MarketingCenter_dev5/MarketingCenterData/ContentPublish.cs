using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingCenterData
{
    public class ContentPublish 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContentPublishId { get; set; } 

        public string? Title { get; set; }
        public string? PrettyUrl { get; set; }
        public string? Path { get; set; }
        public string? Subtitle { get; set; }
        public string? Headline { get; set; }
        public string? Author { get; set; }
        public string? PostDate { get; set; }
        public string? Teaser { get; set; }
        public string? File1HomepageOnly { get; set; }
        public string? TextMarkup { get; set; }
        public string? Text { get; set; }
        public string? MetaDescription { get; set; }
        public string? ImgSpan { get; set; }
        public string? ImgAlign { get; set; }
        public string? ImgWrap { get; set; }
        public string? File4Title { get; set; }
        public string? File5Title { get; set; }
        public string? File6Title { get; set; }
        public string? File7Title { get; set; }
        public string? File8Title { get; set; }
        public string? LinkUrl1 { get; set; }
        public string? LinkUrl2 { get; set; }
        public string? LinkUrl3 { get; set; }
        public string? LinkTitle1 { get; set; }
        public string? LinkTitle2 { get; set; }
        public string? LinkTitle3 { get; set; }
        public string? VideoWidth { get; set; }
        public string? VideoHeight { get; set; }
        public string? VideoAutostart { get; set; }
        public string? VideoLoop { get; set; }
        public string? VidCaption { get; set; }
        public string? AudioArtist { get; set; }
        public string? AudioTitle { get; set; }
        public string? AudioHideInfo { get; set; }
        public string? AudioAutostart { get; set; }
        public string? AudioLoop { get; set; }
        public string? AudioAnimation { get; set; }
        public string? AudioVolume { get; set; }
        public string? ShowComments { get; set; }
        public string? NoNewComments { get; set; }
        public string? PostCategoryId { get; set; }
        public string? PostSubcategoryId { get; set; }
        public string? PostInteriorSubcategoryId { get; set; }
        public string? Geomarket { get; set; }
        public string? Status { get; set; }
        public string? UseDiscontinueDate { get; set; }
        public string? PublishDate { get; set; }
        public string? DiscontinueDate { get; set; }
        public string? HomeFeaturedStatus { get; set; }
        public string? HomeUseDiscontinueDate { get; set; }
        public string? HomeFeaturedDate { get; set; }
        public string? HomeDiscontinueDate { get; set; }
        public string? ShowItemInMobile1 { get; set; }
        public string? ShowItemInMobile2 { get; set; }
        public string? ShowItemInMobile3 { get; set; }
        public string? ShowItemInMobile4 { get; set; }
        public string? CategoryFeaturedStatus { get; set; }
        public string? CategoryUseDiscontinueDate { get; set; }
        public string? CategoryFeaturedDate { get; set; }
        public string? CategoryDiscontinueDate { get; set; }
        public string? Unlocked { get; set; }
        public string? EnableMlsSearch { get; set; }
        public string? PackageTemplate { get; set; }
        public string? PostType { get; set; }
        public string? PostUrl { get; set; }
        public string? StaticDocument { get; set; }
        public string? VisibleToManagers { get; set; }
        public string? DashboardNotifications { get; set; }
        public string? HighPriorityNotificationText { get; set; }
        public string? SearchTags { get; set; }

        public int CategoryIdw { get; set; }
        public int SubcategoryIdw { get; set; }
        public int InteriorSubcategoryIdw { get; set; }

    }
}
