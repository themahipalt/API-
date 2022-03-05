using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModels.Models;
using HandsOnMVCUsingModels.ViewModel;
namespace HandsOnMVCUsingModels.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult OrderDetails()
        {
            Product product = new Product() { ProductId = 334234, ProductName = "Mouse", Price = 500 };
         
            Order order = new Order()
            {
                OrderId = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                DeliveryDate = DateTime.Now.AddDays(7),
                Qty = 5,
                ProductId = product.ProductId,
               
            };
            order.OrderAmount = order.Qty * product.Price;
            ProductOrder orderDetails = new ProductOrder()
            {
                Product = product,
                Order = order
            };
            return View(orderDetails);
        }
    }
}
