using System;
using System.ComponentModel.DataAnnotations;

namespace CrushonCase.Models
{
    public class ProductModel
    {
        [Display(Name = "Article :")]
        public string Title { get; set; }

        [Display(Name = "Prix :")]
        public decimal Price { get; set; }

        [Display(Name = "Stock :")]
        public long Stock { get; set; }
        public bool Enabled { get; set; }
        public long RetailerID { get; set; }
    }
}
