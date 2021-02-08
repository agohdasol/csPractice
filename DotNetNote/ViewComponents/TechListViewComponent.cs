using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.ViewComponents
{
  public class TeachListViewComponent:ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      var techLists = new List<Teach>
      {
        new Teach{Id=1, Title="ASP.NET Core"},
        new Teach{Id=2, Title="asdadasASP.NET Core"},
        new Teach{Id=3, Title="ASP.NETdsadad Core"},
        new Teach{Id=4, Title="ASPdsaad.NET Core"},
        new Teach{Id=5, Title="ASP.NET sdadadssdadasCore"},
      };

      return View(techLists);
    }
  }
}
