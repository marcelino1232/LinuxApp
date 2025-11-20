using System;

namespace Presentacion.Entities;

public class Proveedor
{
    public int ProveedorId { get; set; }
    public string FirstName { get; set; }   
    public string LastName { get; set; }
    public DateTime BornDate { get; set; }
}
