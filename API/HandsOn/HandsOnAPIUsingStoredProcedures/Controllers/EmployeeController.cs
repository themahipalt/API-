using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingStoredProcedures.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
namespace HandsOnAPIUsingStoredProcedures.Controllers
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
            //Invoking the Procedure
            List<Employee> employees = practiceDBContext.Employees.FromSqlRaw("GetEmployees").ToList();
            return StatusCode(200, practiceDBContext.Employees.ToList());
        }
        [HttpGet]
        [Route("GetAll/{id}")]
        public IActionResult Get(int id)
        {
            //set Id to SqlParameter
            SqlParameter parameter = new SqlParameter()
            {
                ParameterName = "@id", Value = id
            };
            Employee employee = practiceDBContext.Employees.FromSqlRaw("GetEmployeeById @id", parameter).SingleOrDefault();
            return StatusCode(200, employee);
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Add(Employee employee)
        {
            // practiceDBContext.Employees.Add(employee);
            // practiceDBContext.SaveChanges();
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter(){ParameterName="@name",Value=employee.EmployeeName},
                new SqlParameter(){ParameterName="@pcode",Value=employee.ProjectCode}
            };
            practiceDBContext.Database.ExecuteSqlRaw("AddEmployee @name,@pcode", parameters);
            return StatusCode(200, "Record Added");
        }
        [HttpPut]
        [Route("EditEmployee")]
        public IActionResult Edit(Employee employee)
        {
            SqlParameter[] parameters = new SqlParameter[3]
              {
                new SqlParameter(){ParameterName="@id",Value=employee.EmployeeId},
                new SqlParameter(){ParameterName="@name",Value=employee.EmployeeName},
                new SqlParameter(){ParameterName="@pcode",Value=employee.ProjectCode}
              };
            practiceDBContext.Database.ExecuteSqlRaw("AddEmployee @eid,@name,@pcode", parameters);
            return StatusCode(200, "Record Edited");
        }
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
            SqlParameter parameter = new SqlParameter()
            {
                ParameterName = "@id",
                Value = id
            };
            practiceDBContext.Database.ExecuteSqlRaw("DeleteEmployee @eid", parameter);
            practiceDBContext.SaveChanges();
            return StatusCode(200, "Record Deleted");
        }

    }
}
