using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop_Registration_Lab.Models;

namespace Coffee_Shop_Registration_Lab.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult Result(Form_Fill f)
    {
        return View(f);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

