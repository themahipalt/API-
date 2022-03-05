using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.API.DBAccess;
using EMS.API.Entities;
namespace EMS.API.Services
{
   public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int employeeId);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        void EditEmployee(Employee employee);
    }
}
