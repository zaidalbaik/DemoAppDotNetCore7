using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoAppDotNet7.Areas.Payments.Controllers
{
    [Area("Payments")]
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index(int? id = null)
        {
            return View();
        }
    }
}
