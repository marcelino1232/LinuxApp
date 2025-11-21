using Presentacion.Interfaces;
using Presentacion.ModelViews;
using Presentacion.Entities;
using Presentacion.Data;

namespace Presentacion.Repositories;

public class ProveedorRepository : IProveedorRepository
{
    private readonly ApplicationDbContext context = new ApplicationDbContext();
    public bool AddProveedor(ProveedorView proveedor)
    {
        var newProveedor = new Proveedor
        {
            ProveedorId = proveedor.ProveedorId,
            FirstName = proveedor.FirstName,
            LastName = proveedor.LastName,
            BornDate = proveedor.BornDate
        };
        context.Proveedores.Add(newProveedor);
        return context.SaveChanges() > 0;
    }

    public List<ProveedorView> GetAllProveedores()
    {
        var proveedorViews = new List<ProveedorView>();
        foreach (var proveedor in context.Proveedores.ToList())
        {
            proveedorViews.Add(new ProveedorView
            {
                ProveedorId = proveedor.ProveedorId,
                FirstName = proveedor.FirstName,
                LastName = proveedor.LastName,
                BornDate = proveedor.BornDate
            });
        }
        return proveedorViews;
    }
}
