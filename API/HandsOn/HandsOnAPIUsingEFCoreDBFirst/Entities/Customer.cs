using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEFCoreDBFirst.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
