using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingStoredProcedures.Entities
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string ProjectCode { get; set; }

        public virtual Project ProjectCodeNavigation { get; set; }
    }
}
