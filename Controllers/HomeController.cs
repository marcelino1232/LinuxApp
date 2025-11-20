using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Interfaces;


namespace Presentacion.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICustomRepository _customRepository;

    public HomeController(ILogger<HomeController> logger, ICustomRepository customRepository)
    {
        _logger = logger;
        _customRepository = customRepository;
    }

    public IActionResult Index()
    {
        var customs = _customRepository.CustomList();
        return View(customs);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }*/
}
