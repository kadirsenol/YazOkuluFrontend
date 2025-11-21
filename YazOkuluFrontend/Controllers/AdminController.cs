using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YazOkuluFrontend.Models;
using YazOkuluFrontend.Models.DTO;
using YazOkuluFrontend.Models.Response;
public class AdminController : Controller
{
    [HttpGet]
    public IActionResult Login() => View();

    [HttpGet]
    public IActionResult Applications()
    {
        return View(new List<ApplicationListItem>());
    }
}
