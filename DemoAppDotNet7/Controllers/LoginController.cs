using Microsoft.AspNetCore.Mvc;

namespace DemoAppDotNet7.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
