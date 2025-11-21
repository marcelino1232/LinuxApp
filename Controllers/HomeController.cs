using System;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Interfaces;

namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomRepository customRepository;

        public HomeController(ICustomRepository customRepository)
        {
            this.customRepository = customRepository;
        }

        public async Task<IActionResult> Index()
        {
            var custom = await customRepository.CustomList();
            return View(custom);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}