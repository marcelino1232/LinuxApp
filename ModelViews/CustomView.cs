using System;

namespace Presentacion.ModelViews;

public class CustomView
{
    public int CustomId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BorsDay { get; set; }
    public DateTime Date { get { return DateTime.Now; } }
}
