using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIWithEFCore_CodeFirst_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        [Route("GetDetails/{id}/{name}")]
        public IActionResult Get(int id,string name)
        {
            return Ok("Method Access");
        }
    }
}
