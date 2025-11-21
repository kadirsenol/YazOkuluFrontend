using Microsoft.AspNetCore.Mvc;
using YazOkuluFrontend.Models;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login() => View();

    [HttpGet]
    public IActionResult VerifyOtp() => View();
}

