using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingCenterData
{
    public class Subcategory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string cat_landing_description { get; set; }
        public string headline { get; set; }
            
        public string cat_landing_description_markup { get; set; }
        public string description_markup { get; set; }
        public bool external_url_active { get; set; }
        public string pretty_url { get; set; }
        public string external_url { get; set; }
        public byte[] file_orig { get; set; }
        public bool Static { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

    }
}
