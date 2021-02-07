using Microsoft.AspNetCore.Mvc;
using System;
using DotNetNote.Services;

namespace DotNetNote.Controllers
{
  public class DependencyInjectionDemoController : Controller
  {
    public IActionResult Index()
    {
      CopyrightService _svc = new CopyrightService();
      ViewBag.Copyright = _svc.GetCopyrightString();
      return View();
    }
    public IActionResult About()
    {
      CopyrightService _svc = new CopyrightService();
      ViewBag.Copyright = _svc.GetCopyrightString();
      return View();
    }
    public IActionResult AtInjectionDemo()
    {
      return View();
    }
  }
}
