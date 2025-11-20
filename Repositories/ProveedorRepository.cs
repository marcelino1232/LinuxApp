using System;
using Presentacion.Interfaces;
using Presentacion.ModelViews;
using Presentacion.Entities;
using System.Collections.Generic;

namespace Presentacion.Repositories;

public class ProveedorRepository : IProveedorRepository
{
    private List<Proveedor> proveedores = new()
    {
        new(){ ProveedorId = 1, FirstName = "Juan", LastName = "Pérez", BornDate = new DateTime(1980, 5, 15) },
        new() { ProveedorId = 2, FirstName = "María", LastName = "Gómez", BornDate = new DateTime(1985, 8, 22) }
    };
    public bool AddProveedor(ProveedorView proveedor)
    {
        var newProveedor = new Proveedor
        {
            ProveedorId = proveedor.ProveedorId,
            FirstName = proveedor.FirstName,
            LastName = proveedor.LastName,
            BornDate = proveedor.BornDate
        };
        proveedores.Add(newProveedor);
        return true;
    }

    public List<ProveedorView> GetAllProveedores()
    {
        var proveedorViews = new List<ProveedorView>();
        foreach (var proveedor in proveedores)
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
