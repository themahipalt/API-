﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InvokeAPIUsingHttpClinet.Models
{
    public class Product
    {
       
        public int Pid { get; set; }
        [Required(ErrorMessage ="Pls Enter Name")]
        public string Pname { get; set; }
        [Required(ErrorMessage = "Pls Enter Price")]
        public int? Price { get; set; }
        [Required(ErrorMessage = "Pls Enter Stock")]
        public int? Stock { get; set; }
    }
}
