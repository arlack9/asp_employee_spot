using core2.Models;
using core2.Repository;
using core2.Repository.Data;
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

        //calling DbSeeding to generate and view Employees

        //DbSeeding dbSeeding = new DbSeeding();

      
        _empRepo.AllEmployees();

        return View(_empRepo);


    }


    public IActionResult Create()
    {
        _empRepo.Add()
    }

    








   
}
