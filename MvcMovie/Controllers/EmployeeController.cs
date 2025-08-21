using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        // /Employee
        public IActionResult Index()
        {
            return View();
        }

        // /Employee/Details
        public IActionResult Details()
        {
            return View();
        }
    }
}
