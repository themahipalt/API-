using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingModelValidation.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Pls Enter CustomreId")]
        public string CustomerId { get; set; }
        [Required(ErrorMessage ="Pls Enter Name")]
        [StringLength(20,ErrorMessage ="Name should not be exceed 20 chars long")]
        [RegularExpression("[a-zA-Z]+",ErrorMessage ="Name should be only alphabets")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Pls Enter Age")]
        [Range(18, 35, ErrorMessage = "Age between 18 to 35")]
        public int Age { get; set; }
        [RegularExpression("[6-9][0-9]{9}",ErrorMessage ="Invalid Mobile No")]
        public string Mobile { get; set; }
        [EmailAddress(ErrorMessage ="Invalid EmailAddess")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Pls Enter Passswor")]
        [RegularExpression("[a-zA-Z0-9]{8}",ErrorMessage ="Invalid Password")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string ConfirmPassword { get; set; }
    }
}
