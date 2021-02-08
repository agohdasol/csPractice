using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
  public class ViewComponentDemoController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    public IActionResult CopyrightDemo()
    {
      return View();
    }
    public IActionResult TeachListDemo()
    {
      return View();
    }
    public IActionResult SiteListDemo()
    {
      return View();
    }
  }
}
