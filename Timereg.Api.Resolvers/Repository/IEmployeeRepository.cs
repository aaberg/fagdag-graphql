namespace Timereg.Api.Resolvers
{
    public interface IEmployeeRepository
    {
        Employee[] GetAllEmployees();
        Employee GetEmployee(int id);

        Employee CreateEmployee(string name, string title);
    }
}