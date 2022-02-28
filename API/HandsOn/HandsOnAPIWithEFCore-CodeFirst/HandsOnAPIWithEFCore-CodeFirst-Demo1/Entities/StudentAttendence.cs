using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities
{
    public class StudentAttendence
    {
        public int StudentAttendenceId { get; set; }
        public Student Student { get; set; } //Navigation property
    }
}
