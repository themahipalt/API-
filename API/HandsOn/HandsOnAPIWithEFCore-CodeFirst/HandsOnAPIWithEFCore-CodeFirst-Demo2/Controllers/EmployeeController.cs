using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Repositories;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository employeeRepository;
        public EmployeeController()
        {
            this.employeeRepository = new EmployeeRepository();
        }
        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult GetAll()
        {
            List<Employee> employees = employeeRepository.GetEmployees();
            return StatusCode(200, employees);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            Employee employee = employeeRepository.GetEmployee(id);
            return StatusCode(200, employee);
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Add(Employee employee)
        {
            employeeRepository.AddEmployee(employee);
            return StatusCode(200);
        }
        [HttpPut]
        [Route("EditEmployee")]
        public IActionResult Edit(Employee employee)
        {
            employeeRepository.EditEmployee(employee);
            return StatusCode(200);
        }
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
            employeeRepository.DeleteEmployee(id);
            return StatusCode(200);
        }
    }
}
