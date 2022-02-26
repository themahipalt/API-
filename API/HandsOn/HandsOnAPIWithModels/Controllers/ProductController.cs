using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithModels.Models;
using HandsOnAPIWithModels.Repositories;
namespace HandsOnAPIWithModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository repository;
        public ProductController()
        {
            this.repository = new ProductRepository();
        }
        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            List<Product> products = repository.GetProducts();
            return Ok(products);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            Product product = repository.GetProduct(id);
            if (product != null)
            {
                return Ok(product);
            }
            else
                return NotFound("Invalid Id");
        }
        //public Product GetById(int id)
        //{
        //    return repository.GetProduct(id);
        //}
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult Add(Product product)
        {
            repository.Save(product);
            return Ok(); //emptry response
        }
        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            repository.Remove(id);
            return Ok("Record Removed");
        }
        [HttpPut]
        [Route("EditProdcut")]
        public IActionResult Edit(Product product)
        {
            repository.Edit(product);
            return Ok();
        }
    }
}
