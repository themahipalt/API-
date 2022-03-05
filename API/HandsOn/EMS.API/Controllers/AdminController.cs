using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.API.Entities;
using EMS.API.Services;
namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        //private readonly EmployeeService employeeService;
        //private readonly ProjectService projectService;

        //public AdminController(EmployeeService employeeService, ProjectService projectService)
        //{
        //    this.employeeService = employeeService;
        //    this.projectService = projectService;
        //}

        private readonly IEmployeeService employeeService;
        private readonly IProjectService projectService;

        public AdminController(IEmployeeService employeeService, IProjectService projectService)
        {
            this.employeeService = employeeService;
            this.projectService = projectService;
        }


        [Route("GetEmployees")]
        [HttpGet]
        public IActionResult GetEmployees()
        {
            try
            {
                return Ok(this.employeeService.GetEmployees());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [Route("GetEmployee/{id}")]
        [HttpGet]
        public IActionResult GetEmployee(int id)
        {
            try
            {
                return Ok(this.employeeService.GetEmployee(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProject(Project project)
        {
            try
            {
                this.projectService.AddProject(project);
                return Ok(); //empty response
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            try
            {
                this.employeeService.AddEmployee(employee);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("EditEmployee")]
        public IActionResult EditEmployee(Employee employee)
        {
            try
            {
                this.employeeService.EditEmployee(employee);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                this.employeeService.DeleteEmployee(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
