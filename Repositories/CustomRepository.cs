using System;
using Presentacion.Interfaces;
using Presentacion.Entities;
using Presentacion.ModelViews;

namespace Presentacion.Repositories;

public class CustomRepository : ICustomRepository
{

    private List<Custom> Customs = new()
   {
       new Custom
       {
           CustomId = 1,
           FirstName = "Marcelino",
           LastName = "Heredia Fernandez",
           BorsDay = Convert.ToDateTime("1975-12-12")
       },
       new Custom
       {
           CustomId = 2,
           FirstName = "Samuel",
           LastName = "Heredia Fernandez",
           BorsDay = Convert.ToDateTime("1975-12-12")
       },
       new Custom
       {
           CustomId = 3,
           FirstName = "Pedro",
           LastName = "Gomez Torrez",
           BorsDay = Convert.ToDateTime("1975-12-12")
       },
       new Custom
       {
           CustomId = 4,
           FirstName = "Andres",
           LastName = "Perez",
           BorsDay = Convert.ToDateTime("1975-12-12")
       }

   };


    public List<CustomView> CustomList()
    {
        var list = new List<CustomView>();

        foreach (var item in Customs)
        {
            var data = new CustomView();

            data.CustomId = item.CustomId;
            data.FirstName = item.FirstName;
            data.LastName = item.LastName;
            data.BorsDay = item.BorsDay;

            list.Add(data);
        }

        return list;
    }

    public bool AddCustom(CustomView custom)
    {
        var newCustom = new Custom
        {

            CustomId = custom.CustomId,
            FirstName = custom.FirstName,
            LastName = custom.LastName,
            BorsDay = custom.BorsDay
        };

        Customs.Add(newCustom);

        return true;
    }

}
