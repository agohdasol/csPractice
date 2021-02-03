using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.Controllers
{
  public class FormValidationDemoController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    #region HTML
    public IActionResult Html()
    {
      return View();
    }
    public IActionResult HtmlProcess(string txtName, string txtContent)
    {
      ViewBag.ResultString = $"이름 : {txtName}, 내용 : {Request.Form["txtContent"]}";
      return View();
    }
    #endregion

    #region Helper Method
    [HttpGet]
    public IActionResult HelperMethod()
    {
      return View();
    }
    [HttpPost]
    public IActionResult HelperMethod(string txtName, string txtContent)
    {
      ViewBag.ResultString = $"이름 : {txtName}, 내용 : {txtContent}";
      return View();
    }
    #endregion

    #region Strongly Type View + Model Binding
    public IActionResult StronglyTypeView()
    {
      return View();
    }
    [HttpPost]
    public IActionResult StronglyTypeView(MaximModel model)
    {
      return View();
    }
    #endregion

    #region Model Validation + Server Validation
    public IActionResult ModelValidation()
    {
      return View();
    }
    [HttpPost]
    public IActionResult ModelValidation(MaximModel model)
    {
      if (string.IsNullOrEmpty(model.Name))
      {
        ModelState.AddModelError("Name", "이름을 입력하세요");
      }
      if (string.IsNullOrEmpty(model.Content))
      {
        ModelState.AddModelError("Content", "내용을 입력하세요");
      }

      if (!ModelState.IsValid)
      {
        ModelState.AddModelError("", "모든 에러");
        return View();
      }
      else
      {
        return View("Completed");
      }
    }
    #endregion

    #region Client Validation
    public IActionResult ClientValidation()
    {
      return View();
    }
    [HttpPost]
    public IActionResult ClientValidation(MaximModel model)
    {
      if (ModelState.IsValid)
      {
        return View("Completed");
      }
      return View();
    }
    #endregion

    #region TagHelper
    public IActionResult TagHelperValidation()
    {
      return View();
    }
    [HttpPost]
    public IActionResult TagHelperValidation(MaximModel model)
    {
      if (ModelState.IsValid)
      {
        return View("Completed");
      }
      return View();
    }
    #endregion
  }
}
