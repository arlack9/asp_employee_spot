using core2.Models;

namespace core2.Repository.Data;

public class DbSeeding
{
    private IEmployeeRepository _empRepo;
    public DbSeeding(IEmployeeRepository empRepo )
    {

        _empRepo = empRepo;

        Employee emp1 = new()
        {
            Id = 1,
            Name = "Arjun",
            Age = 18,
            Dept = "CS"
        };

        Employee emp2 = new()
        {
            Id = 2,
            Name = "Arun",
            Age = 20,
            Dept = "DA"
        };

        Employee emp3 = new()
        {
            Id = 3,
            Name = "Akash",
            Age = 25,
            Dept = "Bio"
        };

        _empRepo.AddEmployee(emp1);
        _empRepo.AddEmployee(emp2);
        _empRepo.AddEmployee(emp3);
      
    }
}
