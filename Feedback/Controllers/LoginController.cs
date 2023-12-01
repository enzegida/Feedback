using Microsoft.AspNetCore.Mvc;

namespace Feedback.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
