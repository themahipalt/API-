using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingModels.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public double OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
