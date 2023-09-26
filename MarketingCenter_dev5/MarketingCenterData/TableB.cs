using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingCenterData
{
    public class TableB
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableBID { get; set; }
        public string SalesName { get; set; }
        public string SalesAddress { get; set; }
        public string SalesCity { get; set; }

        public int TableAID { get; set; }

        [ForeignKey("TableAID")]
        public virtual TableA TableA { get; set; }

    }
}
