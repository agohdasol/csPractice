using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
  public class DemoController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    public IActionResult ContentResultDemo()
    {
      return Content("ContentResult 반환값");
    }
    public IActionResult ContentResultDemo2(int sas)
    {
      return Content($"ContentResult 반환값 {sas}");
    }
  }
}
