using System;
using System.ComponentModel.DataAnnotations;

namespace CrushonCase.Models
{
    public class UserModel
    {
        [Display(Name = "Nom utilisateur :")]
        public string Name { get; set; }

        [Display(Name = "Adresse email :")]
        public string Email { get; set; }

        public string Role { get; set; }

        public int UserID { get; set; }


    }
}
