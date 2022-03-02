using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities
{
    [Table("Projects")]
    public class Project
    {
        [Key] //set as primary key
        [Column(TypeName ="char")]
        [StringLength(5)]
        public string ProjectCode { get; set; }
        [Required] //not null constraint applied
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string ProjectName { get; set; }
        public int? TeamSize { get; set; } //Nullable types makes columns as with null constraint
    }
}
