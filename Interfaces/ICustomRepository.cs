using System;
using System.Collections.Generic;
using Presentacion.ModelViews;


namespace Presentacion.Interfaces;

public interface ICustomRepository
{
    List<CustomView> CustomList();
    bool AddCustom(CustomView custom);
    
}
