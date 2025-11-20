using System;
using Presentacion.ModelViews;


namespace Presentacion.Interfaces;

public interface IProveedorRepository
{
    List<ProveedorView> GetAllProveedores();
    bool AddProveedor(ProveedorView proveedor);
}
