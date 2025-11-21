using System;
using System.Collections.Generic;
using Presentacion.ModelViews;


namespace Presentacion.Interfaces;

public interface ICustomRepository
{
    Task<List<CustomView>> CustomList();
    Task<bool> AddCustom(CustomView custom);
    
}
