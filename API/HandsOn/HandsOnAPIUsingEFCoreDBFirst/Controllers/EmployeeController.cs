using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCoreDBFirst.Entities;
namespace HandsOnAPIUsingEFCoreDBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly PracticeDBContext practiceDBContext;
        public EmployeeController()
        {
            this.practiceDBContext = new PracticeDBContext();
        }
        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult GetAll()
        {
            return StatusCode(200, practiceDBContext.Employees.ToList());
        }
        [HttpGet]
        [Route("GetAll/{id}")]
        public IActionResult Get(int id)
        {
            Employee employee = practiceDBContext.Employees.Find(id);
            return StatusCode(200,employee);
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Add(Employee employee)
        {
            practiceDBContext.Employees.Add(employee);
            practiceDBContext.SaveChanges();
            return StatusCode(200, "Record Added");
        }
        [HttpPut]
        [Route("EditEmployee")]
        public IActionResult Edit(Employee employee)
        {
            practiceDBContext.Employees.Update(employee);
            practiceDBContext.SaveChanges();
            return StatusCode(200, "Record Edited");
        }
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
            Employee employee = practiceDBContext.Employees.Find(id);
            practiceDBContext.Employees.Remove(employee);
            practiceDBContext.SaveChanges();
            return StatusCode(200, "Record Deleted");
        }
    }
}
