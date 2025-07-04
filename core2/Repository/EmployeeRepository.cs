using core2.Models;
using core2.Repository.Data;

namespace core2.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private ApplicationDbContext _db;
    public EmployeeRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public string AddEmployee(Employee employee)
    {
        //throw new NotImplementedException();
        _db.Employees.Add(employee);
        
    }

    public string AllEmployees()
    {
        throw new NotImplementedException();
    }

    public string DeleteEmployee(int Id)
    {
        throw new NotImplementedException();
    }

    public string UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }
}
