using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TheReaLState.Models
{
    public class BuyModel
    {
        public string PropertyID { get; set; }
        [Required]
        public string City { get; set; }
        public string Location { get; set; }
        [Required]
        public string PropertyType { get; set; }
        public string MinPriceRange { get; set; }
        public string MaxPriceRange { get; set; }
        public string AreaInSqYd { get; set; }

        public string Bedrooms { get; set; }
        public bool TVLounge { get; set; }
        public bool OutsideGarden { get; set; }
        public bool WestOpen { get; set; }
        public bool Corner { get; set; }
        public string image { get; set; }
    }
}