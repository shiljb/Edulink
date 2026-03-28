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

    [HttpPost]
    public IActionResult login(string email, string password)
    {
        // Simple mock authentication check
        if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
        {
            // Successful login, redirect to home page
            return RedirectToAction("Index");
        }

        ViewBag.ErrorMessage = "Please enter both email and password.";
        return View();
    }

    public IActionResult signup()
    {
        return View();
    }

    [HttpPost]
    public IActionResult signup(string name, string email, string password)
    {
        // Simple mock registration check
        if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
        {
            // Successful signup, redirect to home page
            return RedirectToAction("Index");
        }

        ViewBag.ErrorMessage = "Please enter all required fields.";
        return View();
    }

    public IActionResult contactus()
    {
        return View();
    }

    public IActionResult Blog()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
