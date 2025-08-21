using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        // /Person
        public IActionResult Index()
        {
            return View();
        }

        // /Person/Details
        public IActionResult Details()
        {
            return View();
        }
    }
}
