using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.ViewComponents
{
  public class TechListViewComponent:ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      var techLists = new List<Tech>
      {
        new Tech{Id=1, Title="ASP.NET Core"},
        new Tech{Id=2, Title="asdadasASP.NET Core"},
        new Tech{Id=3, Title="ASP.NETdsadad Core"},
        new Tech{Id=4, Title="ASPdsaad.NET Core"},
        new Tech{Id=5, Title="ASP.NET sdadadssdadasCore"},
      };

      return View(techLists);
    }
  }
}
