using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MicroservicesContext _context;

        public EmployeeRepository()
        {
            _context = new MicroservicesContext();
        }
        public void AddEmployee(Employee obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = _context.Employee.Find(id);
            _context.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employee.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employee.Find(id);
        }

        public void UpdateEmployee(Employee obj)
        {
            _context.Employee.Update(obj);
            _context.SaveChanges();
        }
    }
}
