namespace Timereg.Api.Resolvers
{
    public class Mutation
    {
        private IEmployeeRepository _employeeRepository;

        public Mutation(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee CreateEmployee(string name, string title)
        {
            return _employeeRepository.CreateEmployee(name, title);
        }
    }
}