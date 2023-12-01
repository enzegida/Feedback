using Microsoft.AspNetCore.Mvc;

namespace Feedback.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Ratings()
        {
            return View();
        }
        public IActionResult Analysis()
        {
            return View();
        }
    }
}
