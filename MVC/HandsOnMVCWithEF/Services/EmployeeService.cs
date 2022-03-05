using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCWithEF.Entities;
namespace HandsOnMVCWithEF.Services
{
    public class EmployeeService
    {
        private readonly RMSDBContext context;

        public EmployeeService(RMSDBContext context)
        {
            this.context = context;
        }

        //public EmployeeService()
        //{
        //    this.context = new RMSDBContext();
        //}
        //Get All Employees
        public List<Employee> GetEmployees()
        {
            return this.context.Employees.ToList();
        }
        //Get Employees using Desingation
        public List<Employee> GetEmployeesByDesignation(string designation)
        {
            return this.context.Employees.Where(e => e.Designation == designation).ToList();
        }
        public Employee GetEmployee(int employeeId)
        {
            return this.context.Employees.Find(employeeId); //FInd is for PK
        }
        //Get Employee By Name
        public Employee GetEmployeeByName(string employeeName)
        {
            return this.context.Employees.Single(e => e.EmployeeName == employeeName);
            //expression return null when there is no record
            //return this.context.Employees.SingleOrDefault(e => e.EmployeeName == employeeName);
        }
        public void AddEmployee(Employee employee)
        {
            this.context.Employees.Add(employee);
            context.SaveChanges();
        }
        public void DeleteEmployee(int employeeId) //Remove Employee using Id
        {
            Employee employee = context.Employees.Find(employeeId);
            this.context.Employees.Remove(employee);
            this.context.SaveChanges();

        }
        //public void EditEmployee(int employeeId,string designation,string projectCode)
        //{
        //    Employee employee = context.Employees.Find(employeeId);
        //    employee.Designation = designation;
        //    employee.ProjectCode = projectCode;
        //    this.context.SaveChanges();

        //}
        public void EditEmployee(Employee employee)
        {
            this.context.Employees.Update(employee);
            this.context.SaveChanges();

        }
    }
}
