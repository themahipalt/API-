using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Key] //applied pk with identity
        public int EmployeeId { get; set; }
        [StringLength(30)]
        [Required]
        [Column(TypeName ="varchar")]
        public string EmployeeName { get; set; }
        [ForeignKey("Project")]
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string ProjectCode { get; set; }

        public Project Project { get; set; }
    }
}
