using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using crudAspNet.Models;

namespace crudAspNet.Controllers;

public class  HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Read()
    {
        return View();
    }
    
    public IActionResult Update()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}