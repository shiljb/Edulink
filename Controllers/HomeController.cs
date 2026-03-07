using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace EduLinkApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Courses()
    {
        return View();
    }

    public IActionResult Pages()
    {
        return View();
    }

    public IActionResult login()
    {
        return View();
    }

    public IActionResult signup()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
