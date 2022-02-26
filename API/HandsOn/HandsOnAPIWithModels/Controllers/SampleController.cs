using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIWithModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "India", "China", "Japan" });
        }
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            try
            {
                throw new Exception();
                return Ok("Hello " + name.ToUpper());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post(object obj)
        {
            return Ok("Resource Added");
        }
        [HttpPut]
        public string Put(object obj)
        {
            // return Ok("Resource Updated");
            return "Resorce Updated";
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Resource Deleted");
        }
    }
}
