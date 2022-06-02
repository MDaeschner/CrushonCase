using System;
using System.ComponentModel.DataAnnotations;

namespace CrushonCase.Models
{
    public class LogginModel
    {
        [Display(Name = "Adresse email :")]
        public string Email { get; set; }

    }
}
