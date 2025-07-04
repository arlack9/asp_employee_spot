using core2.Models;

namespace core2.Repository;

public interface IEmployeeRepository
{
    public string AddEmployee(Employee employee);

    public string DeleteEmployee(int Id);

    public string UpdateEmployee(Employee employee);

    public string AllEmployees();

}
