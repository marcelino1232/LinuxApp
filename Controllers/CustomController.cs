using Microsoft.AspNetCore.Mvc;
using Presentacion.Interfaces;

namespace Presentacion.Controllers;


public class CustomController : Controller
{
    private readonly ICustomRepository customRepository;

    public CustomController(ICustomRepository customRepository)
    {
        this.customRepository = customRepository;
    }
    
    [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, NoStore = false)]
    public IActionResult Index()
    {
        return View();
    }
}
