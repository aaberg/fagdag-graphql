using System.Collections.Generic;

namespace Timereg.Api.Resolvers
{
    public class Query
    {
        private IEmployeeRepository _employeeRepository;

        public Query(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee[] Employees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public Employee Employee(int id)
        {
            return _employeeRepository.GetEmployee(id);
        }
    }
}