using Lab_2.Services.IServices;
using Lab_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.Services
{
    internal class SqlServerEmployeeService : IEmployeeService
    {
        NorthwindContext _context = new NorthwindContext();

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
