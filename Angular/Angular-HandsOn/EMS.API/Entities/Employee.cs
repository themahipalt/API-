using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EMS.API.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //disable the identity
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(30)]
        public string EmployeeName { get; set; }
        [ForeignKey("Project")]
        public string ProjectId { get; set; } //set as fk

        public Project Project { get; set; } //Navigatio property for fk ration
    }
}
