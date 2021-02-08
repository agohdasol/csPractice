using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Net.Http.Headers;
using System.IO;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
  public class FileDemoController : Controller
  {
    private IHostingEnvironment _environment;
    public FileDemoController(IHostingEnvironment environment)
    {
      _environment = environment;
    }
    [HttpGet]
    public IActionResult FileUploadDemo()
    {
      return View();
    }
    public IActionResult Index()
    {
      return View();
    }
  }
}
