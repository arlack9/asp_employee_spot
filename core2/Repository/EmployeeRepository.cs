using core2.Models;
using core2.Repository.Data;

//this represents the DAL layer
namespace core2.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    //success saving return >1 (no of entries written/changed)s else 0 , validation error -1

    private ApplicationDbContext _db;
    public EmployeeRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public int AddEmployee(Employee employee)
    {
        //this add operation to DbSet only 
        _db.Employees.Add(employee);

        //commit to db
        return _db.SaveChanges();
    }

    public List<Employee> AllEmployees()
    {
        
        
        return _db.Employees.ToList();

      
    }

    public int DeleteEmployee(int Id)
    {
        var employee = _db.Employees.Find(Id);
        if(employee==null)
        {
            return -1;
        }
        _db.Employees.Remove(employee);
        return _db.SaveChanges();
    }

    public int UpdateEmployee(Employee employee)
    {

        if (employee == null)
            return -1;

        _db.Employees.Update(employee);
        return _db.SaveChanges();
    }
}
