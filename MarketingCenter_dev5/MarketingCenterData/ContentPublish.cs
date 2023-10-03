using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingCenterData
{
    public class ContentPublish
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ContentPublishId { get; set; }

        public string title { get; set; }
        public string pretty_url { get; set; }
        public string path { get; set; }
        public string subtitle { get; set; }
        public string headline { get; set; }
        public string author { get; set; }
        public string post_date { get; set; }
        public string teaser { get; set; }
        public string file_1_homepage_only { get; set; }
        public string text_markup { get; set; }
        public string text { get; set; }
        public string meta_description { get; set; }
        public string img_span { get; set; }
        public string img_align { get; set; }
        public string img_wrap { get; set; }
        public string file_4_title { get; set; }
        public string file_5_title { get; set; }
        public string file_6_title { get; set; }
        public string file_7_title { get; set; }
        public string file_8_title { get; set; }
        public string link_url_1 { get; set; }
        public string link_url_2 { get; set; }
        public string link_url_3 { get; set; }
        public string link_title_1 { get; set; }
        public string link_title_2 { get; set; }
        public string link_title_3 { get; set; }
        public string video_width { get; set; }
        public string video_height { get; set; }
        public string video_autostart { get; set; }
        public string video_loop { get; set; }
        public string vid_caption { get; set; }
        public string audio_artist { get; set; }
        public string audio_title { get; set; }
        public string audio_hide_info { get; set; }
        public string audio_autostart { get; set; }
        public string audio_loop { get; set; }
        public string audio_animation { get; set; }
        public string audio_volume { get; set; }
        public string show_comments { get; set; }
        public string no_new_comments { get; set; }
        public string post_category_id { get; set; }
        public string post_subcategory_id { get; set; }
        public string post_interior_subcategory_id { get; set; }
        public string Geomarket { get; set; }
        public string status { get; set; }
        public string use_discontinue_date { get; set; }
        public string publish_date { get; set; }
        public string discontinue_date { get; set; }
        public string home_featured_status { get; set; }
        public string home_use_discontinue_date { get; set; }
        public string home_featured_date { get; set; }
        public string home_discontinue_date { get; set; }
        public string show_item_in_mobile1 { get; set; }
        public string show_item_in_mobile2 { get; set; }
        public string show_item_in_mobile3 { get; set; }
        public string show_item_in_mobile4 { get; set; }
        public string category_featured_status { get; set; }
        public string category_use_discontinue_date { get; set; }
        public string category_featured_date { get; set; }
        public string category_discontinue_date { get; set; }
        public string unlocked { get; set; }
        public string enable_mls_search { get; set; }
        public string package_template { get; set; }
        public string post_type { get; set; }
        public string post_url { get; set; }
        public string static_document { get; set; }
        public string visible_to_managers { get; set; }
        public string dashboard_notifications { get; set; }
        public string high_priority_notification_text { get; set; }
        public string search_tags { get; set; }

        public int CategoryIdw { get; set; }
        public int SubcategoryIdw { get; set; }
        public int InteriorSubcategoryIdw { get; set; }

    }
}
