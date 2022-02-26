using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithModels.Models;
namespace HandsOnAPIWithModels.Repositories
{
    interface IProductRepository
    {
        void Save(Product product);
        List<Product> GetProducts();
        Product GetProduct(int productId);
        void Remove(int productId);
        void Edit(Product product);
    }
}
