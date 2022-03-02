using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Repositories
{
    interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        List<Employee> GetEmployees();
        Employee GetEmployee(int employeeId);
        void EditEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}
