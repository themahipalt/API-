using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCWithEF.Models
{
    public class ProjectDTO
    {
       [Required(ErrorMessage ="Pls Enter ProjectCode")]
        public string ProjectCode { get; set; }
        [Required(ErrorMessage ="Pls Enter ProjectName")]
        public string ProjectName { get; set; }
    }
}
