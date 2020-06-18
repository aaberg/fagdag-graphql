using System.Collections.Generic;
using System.Linq;

namespace Timereg.Api.Resolvers
{
    public class MemoryEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _allEmployees;

        public MemoryEmployeeRepository()
        {
            _allEmployees = new List<Employee>
            {
                new Employee {Id = 1, Name = "Lars Aaberg", Title = "Konsulent"},
                new Employee {Id = 2, Name = "Ola Normann", Title = "Dyrepasser"}
            };
        }

        public Employee[] GetAllEmployees()
        {
            return _allEmployees.ToArray();
        }

        public Employee GetEmployee(int id)
        {
            return _allEmployees.SingleOrDefault(employee => employee.Id == id);
        }

        public Employee CreateEmployee(string name, string title)
        {
            var newEmployee = new Employee()
            {
                Name = name,
                Title = title,
                Id = _allEmployees.Max(e => e.Id) + 1
            };
            _allEmployees.Add(newEmployee);
            return newEmployee;
        }
    }
}