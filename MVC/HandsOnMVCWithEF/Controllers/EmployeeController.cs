using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCWithEF.Services;
using HandsOnMVCWithEF.Models;
using HandsOnMVCWithEF.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMVCWithEF.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService employeeService;
        private readonly ProjectService projectService;

        public EmployeeController(EmployeeService employeeService, ProjectService projectService)
        {
            this.employeeService = employeeService;
            this.projectService = projectService;
        }

        //public EmployeeController()
        //{
        //    this.employeeService = new EmployeeService();
        //    this.projectService = new ProjectService();
        //}
        [Route("Employee/GetAll")]
        public IActionResult Index() //Get All Employees
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            List<Employee> employees=employeeService.GetEmployees();
            #region Covert Employee to EmployeeDTO
            foreach (Employee item in employees) //converting Employees to EmployeeDTO
            {
                employeeDTOs.Add(new EmployeeDTO()
                {
                    EmployeeId = item.EmployeeId,
                    EmployeeName = item.EmployeeName,
                    Designation = item.Designation,
                    JoinDate = item.JoinDate,
                    ProjectCode = item.ProjectCode
                });
            } 
            #endregion
            return View(employeeDTOs);
        }
        public IActionResult Create()
        {
            #region Binding Dropdowns
            List<Project> projects = projectService.GetProjects();
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (Project project in projects)
            {
                listItems.Add(new SelectListItem { Text = project.ProjectName, Value = project.ProjectCode });
            }
            ViewBag.Desingations = new SelectList(new string[] { "Programmer", "Sr Programmer", "TeamLeader", "PrjectLeader" });
            ViewData["items"] = listItems; 
            #endregion
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeDTO employeeDTO)
        {
            #region Create New Employee
            if (ModelState.IsValid)
            {
                Employee employee = new Employee()
                {
                    EmployeeId = employeeDTO.EmployeeId,
                    EmployeeName = employeeDTO.EmployeeName,
                    Designation = employeeDTO.Designation,
                    JoinDate = employeeDTO.JoinDate,
                    ProjectCode = employeeDTO.ProjectCode
                };
                employeeService.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            } 
            #endregion
        }
        public IActionResult Details(int employeeId)
        {
            #region Employee Details
            Employee employee = employeeService.GetEmployee(employeeId);
            //Converting Employee to EmployeeDTO
            EmployeeDTO employeeDTO = new EmployeeDTO()
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                Designation = employee.Designation,
                JoinDate = employee.JoinDate,
                ProjectCode = employee.ProjectCode
            };
            return View(employeeDTO); 
            #endregion
        }
        public IActionResult Delete(int employeeId)
        {
            #region DeleteEmployee
            employeeService.DeleteEmployee(employeeId);
            return RedirectToAction("Index"); 
            #endregion
        }
        public IActionResult Edit(int employeeId)
        {
            #region BindingDropDown
            List<Project> projects = projectService.GetProjects();
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (Project project in projects)
            {
                listItems.Add(new SelectListItem { Text = project.ProjectName, Value = project.ProjectCode });
            }
            ViewBag.Desingations = new SelectList(new string[] { "Programmer", "Sr Programmer", "TeamLeader", "PrjectLeader" });
            ViewData["items"] = listItems;
            #endregion
            #region Edit Employee
            Employee employee = employeeService.GetEmployee(employeeId);
            //Coverting Employee to EmployeeDTO
            EmployeeDTO employeeDTO = new EmployeeDTO()
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                Designation = employee.Designation,
                JoinDate = employee.JoinDate,
                ProjectCode = employee.ProjectCode
            };
            return View(employeeDTO); 
            #endregion

        }
        [HttpPost]
        public IActionResult Edit(EmployeeDTO employeeDTO)
        {
            #region Edit Employee
            //Converting EmployeeDTO to Employee
            Employee employee = new Employee()
            {
                EmployeeId = employeeDTO.EmployeeId,
                EmployeeName = employeeDTO.EmployeeName,
                Designation = employeeDTO.Designation,
                JoinDate = employeeDTO.JoinDate,
                ProjectCode = employeeDTO.ProjectCode
            };
            employeeService.EditEmployee(employee);
            return RedirectToAction("Index"); 
            #endregion
        }

    }
}
