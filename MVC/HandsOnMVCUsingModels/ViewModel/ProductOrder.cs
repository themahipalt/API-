using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModels.Models;
namespace HandsOnMVCUsingModels.ViewModel
{
    public class ProductOrder
    {
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
