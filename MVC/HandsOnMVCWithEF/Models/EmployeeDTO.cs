using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCWithEF.Models
{
    public class EmployeeDTO
    {
        //[Required(ErrorMessage ="Pls Enter Id")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Pls Enter Name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Pls Enter JoinDate")]
        public DateTime? JoinDate { get; set; }
        [Required(ErrorMessage = "Pls Enter Designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Pls Enter Project")]
        public string ProjectCode { get; set; }
    }
}
