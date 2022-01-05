using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using C3mvc.Models;

namespace C3mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<Team> _teams;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _teams = new List<Team>();
    }

    public IActionResult Teams()
    {
        _teams.Add(new Team("Barcelona", 1));
        _teams.Add(new Team("Atletico", 2));
        _teams.Add(new Team("Real Madrid", 3));
        return View(_teams);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
