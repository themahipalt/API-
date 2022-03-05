using InvokeAPIUsingJQuery.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace InvokeAPIUsingJQuery.Services
{
    public class ProductService : IProductService
    {
        public void Add(Product item)
        {
           using(HttpClient client=new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44365/");
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/Product/Add", contentData).Result;
            }
        }

      

        public Product Get(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44365/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Product/GetById/"+Id).Result;
                Product item = JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
                return item;
            }
        }

        public List<Product> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44365/");
                MediaTypeWithQualityHeaderValue contentType =new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Product/GetAll").Result;
                List<Product> list = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }

        public void Update(Product item)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44365/");
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/Product/Update", contentData).Result;
            }
        }
        public void Delete(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44365/");
                HttpResponseMessage response = client.DeleteAsync("api/Product/Delete/"+Id).Result;
            }
        }
    }
}
