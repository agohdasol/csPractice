using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
  public class ViewBagDemoController : Controller
  {
    public IActionResult Index()
    {
      ViewBag.Name = "박용준";
      ViewBag.Age = 21;
      ViewData["Address"] = "세종시";
      return View();
    }
  }
}
