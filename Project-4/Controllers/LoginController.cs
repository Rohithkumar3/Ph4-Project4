using Microsoft.AspNetCore.Mvc;

namespace Project_4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            return RedirectToAction("Dashboard", "Home", new { username = username });
        }
    }
}
