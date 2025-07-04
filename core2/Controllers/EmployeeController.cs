using core2.Models;
using Microsoft.AspNetCore.Mvc;

namespace core2.Controllers
{
    public class EmployeeController : Controller
    {

        //Registering DI with Ilogger for logging 
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;  
        }

        //_logger.

        //Home page for Devs
        public IActionResult Index()
        {
           
            _logger.LogInformation(DateTime.UtcNow.ToString());

            //debug

            List<Employee> emp = new() {
                  new() { Id=1, Name ="Arjun" , Age=18, Dept="cs"}
                  };


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
}
