using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAttributeRouting.Models;
namespace HandsOnAttributeRouting.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("Employee/GetEmployees")]
        public IActionResult Index() //GetEmployees
        {
            return View();
        }
        [Route("MVC/Employee/GetEmployeeById/{id}")]
        public IActionResult Detaisl(int id)
        {
            return View();
        }
        [Route("Employee/GetByName/{name}")]
        public IActionResult GetEmployeeByName(string name)
        {
            return View();
        }
        [Route("Employee/AddEmployee")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("Employee/AddEmployee")]
        public IActionResult Add(Employee employee)
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
