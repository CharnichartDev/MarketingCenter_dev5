using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace MarketingCenterData
{
    public class CategoryBase
    {
        public string? Name { get; set; }
        public string? CatLandingDescription { get; set; }
        public string? Headline { get; set; }
        public string? CatLandingDescriptionMarkup { get; set; }
        public string? DescriptionMarkup { get; set; }
        public bool ExternalUrlActive { get; set; }
        public string? PrettyUrl { get; set; }
        public string? ExternalUrl { get; set; }
        public byte[]? FileOrig { get; set; }
        public bool Static { get; set; }
        public bool OnDisplay { get; set; }
    }
}
