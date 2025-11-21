using System;
using Presentacion.Interfaces;
using Presentacion.Entities;
using Presentacion.ModelViews;
using static System.Net.Mime.MediaTypeNames;
using Presentacion.Data;
using Microsoft.EntityFrameworkCore;

namespace Presentacion.Repositories;

public class CustomRepository(ApplicationDbContext context) : ICustomRepository
{

   
    public async Task<List<CustomView>> CustomList()
    {
        var list = new List<CustomView>();

        var customs =  await context.Customs.ToListAsync();

        foreach (var item in customs)
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

    public async Task<bool> AddCustom(CustomView custom)
    {
        var newCustom = new Custom
        {

            CustomId = custom.CustomId,
            FirstName = custom.FirstName,
            LastName = custom.LastName,
            BorsDay = custom.BorsDay
        };

        context.Customs.Add(newCustom);

        var result = await context.SaveChangesAsync() > 0;

        if(!result)
        {
            throw new Exception("Error al guardar el nuevo Custom");
        }

        return result;
    }

}
