using Microsoft.AspNetCore.Mvc;
using Presentacion.Interfaces;

namespace Presentacion.Controllers;

public class ProveedorController: Controller
{
    private readonly IProveedorRepository _proveedorRepository;

    public ProveedorController(IProveedorRepository proveedorRepository)
    {
        _proveedorRepository = proveedorRepository;
    }

    
    public IActionResult Index()
    {
        var proveedores = _proveedorRepository.GetAllProveedores();
        return View(proveedores);
    }
}
