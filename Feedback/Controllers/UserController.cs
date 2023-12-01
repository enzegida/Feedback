using Microsoft.AspNetCore.Mvc;

namespace Feedback.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }
        public IActionResult FeedbackList()
        {
            return View();
        }
    }
}
