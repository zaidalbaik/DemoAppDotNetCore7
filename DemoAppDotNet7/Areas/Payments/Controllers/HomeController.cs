using Microsoft.AspNetCore.Mvc;

namespace DemoAppDotNet7.Areas.Payments.Controllers
{
    [Area("Payments")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
