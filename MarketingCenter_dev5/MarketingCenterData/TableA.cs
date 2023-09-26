using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingCenterData
{
    public class TableA
    {
        // generate random named properties the property ID is a primary key and is auto generated


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableAID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }



    }
}
