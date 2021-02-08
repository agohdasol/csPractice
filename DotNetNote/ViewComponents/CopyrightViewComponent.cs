using System;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.ViewComponents
{
  public class CopyrightViewComponent:ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      string viewName = "Default";
      if (DateTime.Now.Second % 2 == 0)
      {
        viewName = "Details";
      }
      return View(viewName);
    }
  }
}
