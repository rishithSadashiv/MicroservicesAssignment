using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Repositories
{
    interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetById(int id);
        void AddEmployee(Employee obj);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee obj);
    }
}
