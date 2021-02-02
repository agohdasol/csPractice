using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.Controllers
{
  public class DataController : Controller
  {
    public IActionResult Index()
    {
      DataService demoService = new DataService();
      var data = demoService.GetAll();
      return View(data);
    }
  }
}
