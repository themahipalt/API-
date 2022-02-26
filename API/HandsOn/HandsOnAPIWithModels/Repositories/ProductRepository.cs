using HandsOnAPIWithModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIWithModels.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public static List<Product> products = new List<Product>() //inmomory list
        {
            new Product(){ProductId=1323,ProductName="Mouse",Price=500,Stock=10},
            new Product(){ProductId=4567,ProductName="Keypad",Price=300,Stock=10},
        };
        public void Edit(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == product.ProductId)
                {
                    //products[i] = product;
                    products[i].Stock = product.Stock;
                    products[i].Price = product.Price;
                    break;
                }
            }
            //Product Oldproduct = products.Single(p => p.ProductId == product.ProductId);
            //products.Remove(Oldproduct);
            //products.Add(product);

        }

        public Product GetProduct(int productId)
        {
            return products.SingleOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void Remove(int productId)
        {
            Product product = products.Single(p => p.ProductId == productId);
            products.Remove(product);
        }

        public void Save(Product product)
        {
            products.Add(product);
        }
    }
}
