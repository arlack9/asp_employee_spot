using core2.Models;
using core2.Repository;
using Microsoft.AspNetCore.Mvc;

//this represents the BLL layer
namespace core2.Controllers;

public class EmployeeController : Controller
{

    //Registering DI with Ilogger for logging 
    private readonly ILogger<EmployeeController> _logger;

    private readonly IEmployeeRepository _empRepo;
    public EmployeeController(ILogger<EmployeeController> logger , IEmployeeRepository empRepo)
    {
        _logger = logger;
        _empRepo = empRepo;
    }

    //_logger.

    //Home page for Devs
    public IActionResult Index()
    {
       
        _logger.LogInformation(DateTime.UtcNow.ToString());

        //UI debug 

        //List<Employee> emp = new() {
        //new() { Id=1, Name ="Arjun" , Age=18, Dept="cs"}
        //};
        _empRepo.AllEmployees();

        return View(emp);


    }


    //public IActionResult Randomact()
    //{
    //   List <Employee> emp = new() {
    //      new() { Id=1, Name ="Arjun" , Age=18, Dept="cs"}
    //      };

    //    return View(emp);
    //}





   
}
