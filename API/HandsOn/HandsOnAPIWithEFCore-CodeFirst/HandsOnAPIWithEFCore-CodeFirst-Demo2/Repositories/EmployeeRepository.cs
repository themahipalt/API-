using HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.DBAccess;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HappyDB228Context dbContext;
        public EmployeeRepository()
        {
            this.dbContext = new HappyDB228Context();
        }
        public void AddEmployee(Employee employee)
        {
            this.dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            Employee employee = dbContext.Employees.Find(employeeId);
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
        }

        public void EditEmployee(Employee employee)
        {
            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();
        }

        public Employee GetEmployee(int employeeId)
        {
            Employee employee = dbContext.Employees.SingleOrDefault(e=>e.EmployeeId==employeeId);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }
    }
}
