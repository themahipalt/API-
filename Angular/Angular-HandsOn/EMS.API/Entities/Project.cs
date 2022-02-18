using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EMS.API.Entities
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [StringLength(5)]
        [Column(TypeName ="char")]
        public string ProjectId { get; set; }

        [Required]
        [StringLength(20)]
        public string ProjectName { get; set; }
        public int? TeamSize { get; set; }
    }
}
