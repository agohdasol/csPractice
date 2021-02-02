using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DotNetNote.Controllers
{
  public class MovieListController : Controller
  {
    public IActionResult Index()
    {
      List<MovieViewModel> vms = new List<MovieViewModel>()
      {
        new MovieViewModel{Id=1,Title="명량", CreationDate=new DateTime(2014,1,1)},
        new MovieViewModel{Id=2,Title="실미도", CreationDate=new DateTime(2003,1,1)},
        new MovieViewModel{Id=3,Title="베테랑", CreationDate=new DateTime(2015,1,1)},
      };
      return View(vms);
    }
  }
}
