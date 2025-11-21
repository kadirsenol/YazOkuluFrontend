using Microsoft.AspNetCore.Mvc;

namespace YazOkuluFrontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
