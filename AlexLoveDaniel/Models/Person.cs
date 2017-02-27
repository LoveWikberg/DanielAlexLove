using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlexLoveDaniel.Models
{
    public class Person
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Enter your name...")]
        public string Name { get; set; }


        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Enter your E-mail...")]
        [EmailAddress(ErrorMessage = "Invalid E-mail")]
        public string Email { get; set; }

        [Display(Name = "Id")]
        public int Id { get; set; }

    }
}
