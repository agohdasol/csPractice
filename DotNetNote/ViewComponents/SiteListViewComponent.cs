using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.ViewComponents
{
  public class SiteListViewComponent:ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      var siteLists = new List<Site>()
      {
        new Site{Id=1,Title="길벗출판사",Url="http://gilbut.co.kr", Description="ASP.NET 서적 출간"},
        new Site{Id=2,Title="ㅂㄷ사",Url="http://gilbut1.co.kr", Description="A123SP.NET 서적 출간"},
        new Site{Id=3,Title="길벗ㅂㅈㄷ사",Url="http://gilbut2.co.kr", Description="ASP1231123.NET 서적 출간"},
        new Site{Id=4,Title="길벗출ㄷㄱㅈ",Url="http://gilbut3.co.kr", Description="ASP.NET 서42535적 출간"},
      };
      return View(siteLists);
    }
  }
}
