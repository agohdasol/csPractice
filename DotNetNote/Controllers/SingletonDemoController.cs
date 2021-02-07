using Microsoft.AspNetCore.Mvc;
using DotNetNote.Services;

namespace DotNetNote.Controllers
{
  public class SingletonDemoController : Controller
  {
    private readonly IInfoService _svc;
    public SingletonDemoController(IInfoService svc)
    {
      _svc = svc;
    }
    public IActionResult ConstructorInjectionDemo()
    {
      ViewData["Url"] = _svc.GetUrl();
      return View("Index");
    }
    public IActionResult Index()
    {
      ViewData["Url"] = "www.gilbut.co.kr";
      return View();
    }
    public IActionResult InfoServiceDemo()
    {
      InfoService svc = new InfoService();
      ViewData["Url"] = svc.GetUrl();
      return View("Index");
    }
  }
}
