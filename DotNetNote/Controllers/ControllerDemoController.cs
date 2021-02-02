using Microsoft.AspNetCore.Mvc;
using System;

namespace DotNetNote.Controllers
{
  public class ControllerDemoController : Controller
  {
    public void Index()
    {
    }
    public string StringAction()
    {
      return "String을 반환하는 메서드";
    }
    public DateTime DateTimeAction()
    {
      return DateTime.Now;
    }
    public IActionResult DefaultAction()
    {
      return View();
    }
  }
}
