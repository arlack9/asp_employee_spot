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

        var empsList=_empRepo.AllEmployees().ToList();

        return View(empsList);


    }

        public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee obj)
    {

        _empRepo.AddEmployee(obj); //Add new diary entry to database
       
        return RedirectToAction("Index");
    }

   
}


  







   

