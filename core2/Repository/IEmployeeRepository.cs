using core2.Models;

namespace core2.Repository;

public interface IEmployeeRepository
{
    public int AddEmployee(Employee employee);

    public int DeleteEmployee(int Id);

    public int UpdateEmployee(Employee employee);

    public List<Employee> AllEmployees();

}
