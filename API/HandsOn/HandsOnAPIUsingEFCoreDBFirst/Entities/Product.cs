﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEFCoreDBFirst.Entities
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
