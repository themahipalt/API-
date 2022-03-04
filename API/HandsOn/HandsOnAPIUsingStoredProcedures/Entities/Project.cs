﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingStoredProcedures.Entities
{
    public partial class Project
    {
        public Project()
        {
            Employees = new HashSet<Employee>();
        }

        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
