using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvokeAPIUsingJQuery.Services;
using InvokeAPIUsingJQuery.Models;
namespace InvokeAPIUsingJQuery.Services
{
    interface IProductService
    {
        List<Product> GetAll();
        Product Get(int Id);
        void Add(Product item);
        void Update(Product item);
        void Delete(int Id);
    }
}
