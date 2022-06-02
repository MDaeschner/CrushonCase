using System;
using System.ComponentModel.DataAnnotations;

namespace CrushonCase.Models
{
    public class BrandModel
    {
        [Display(Name = "Nom marque :")]
        public string Name { get; set; }
        
    }
}
