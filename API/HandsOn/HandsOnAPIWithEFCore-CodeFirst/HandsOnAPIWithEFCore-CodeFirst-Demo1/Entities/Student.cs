using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities
{
    public class Student
    {
        public int Id { get; set; } // set as PK and identity will be applied
        public string Name { get; set; }
        public int Age { get; set; }
        public string SchollName { get; set; }
        public string Std { get; set; }
    }

}
