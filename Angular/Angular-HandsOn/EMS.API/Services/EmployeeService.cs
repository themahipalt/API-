using EMS.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.API.DBAccess;
namespace EMS.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EMSDBContext eMSDBContext;
        public EmployeeService()
        {
            this.eMSDBContext = new EMSDBContext();
        }
        public void AddEmployee(Employee employee)
        {
            this.eMSDBContext.Employees.Add(employee);
            this.eMSDBContext.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            Employee employee = this.eMSDBContext.Employees.Find(employeeId);
            this.eMSDBContext.Employees.Remove(employee);
            this.eMSDBContext.SaveChanges();
        }

        public void EditEmployee(Employee employee)
        {
            this.eMSDBContext.Employees.Update(employee);
            this.eMSDBContext.SaveChanges();
        }

        public Employee GetEmployee(int employeeId)
        {
            return this.eMSDBContext.Employees.Find(employeeId);
        }

        public List<Employee> GetEmployees()
        {
            return this.eMSDBContext.Employees.ToList();
        }
    }
}
