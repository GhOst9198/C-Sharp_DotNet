using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace TheReaLState.Models
{
    public class AddPropertyModel
    {
        public int PropertyID { get; set; }
        [Required]
        public string Purpose { get; set; }
        [Required]
        public string PropertyType { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string PropertyTitle { get; set; }
        public string Description { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string LandArea { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public HttpPostedFileBase ProductImage { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Bedrooms { get; set; }
        public bool TVLounge { get; set; }
        public bool WestOpen { get; set; }
        public bool OutsideGarden { get; set; }
        public bool Corner { get; set; }
    }
}