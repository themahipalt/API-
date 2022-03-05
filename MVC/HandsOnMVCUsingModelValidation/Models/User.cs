using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingModelValidation.Models
{
    public class User
    {
        [Required(ErrorMessage ="Pls Enter EmailId")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Pls Enter Password")]
        public string Password { get; set; }
    }
}
