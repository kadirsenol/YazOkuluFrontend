using Microsoft.AspNetCore.Mvc;
using YazOkuluFrontend.Models;

public class CoursesController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Apply(int courseId)
    {
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult AddCourse(int courseId)
    {
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult MyApplications()
    {
        return View();
    }
}

