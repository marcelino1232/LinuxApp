using Microsoft.AspNetCore.Mvc;
using Presentacion.Interfaces;

namespace Presentacion.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IProveedorRepository proveedorRepository;

        public ProveedorController(IProveedorRepository proveedorRepository)
        {
            this.proveedorRepository = proveedorRepository;
        }
        // GET: ProveedorController
        public ActionResult Index()
        {
            var proveedores = proveedorRepository.GetAllProveedores();
            return View(proveedores);
        }

    }
}
