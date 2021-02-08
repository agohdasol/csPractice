using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
  public class BoardSummaryModel
  {
    public int Id { get; set; }
    public string Alias { get; set; }
    public string Title { get; set; }
    public string Name { get; set; }
    public DateTime PostDate { get; set; }
  }
  public class BoardSummaryRepository
  {
    public List<BoardSummaryModel> GetAll()
    {
      var lists = new List<BoardSummaryModel>()
      {
        new BoardSummaryModel
        {
          Id=1, Alias="Notice", Name="홍길돌", Title="공지사항압니다", PostDate=DateTime.Now
        },
        new BoardSummaryModel
        {
          Id=2, Alias="Free", Name="백두산", Title="자유게시시파파판", PostDate=DateTime.Now
        },
        new BoardSummaryModel
        {
          Id=3, Alias="Photo", Name="임꺽정", Title="사진게시판ㅇ", PostDate=DateTime.Now
        },
        new BoardSummaryModel
        {
          Id=4, Alias="Notice", Name="긱김밥", Title="공지지", PostDate=DateTime.Now
        },
      };
      return lists;
    }
    public List<BoardSummaryModel> GetByAlias(string alias)
    {
      return GetAll().Where(b => b.Alias == alias).ToList();
    }
  }

  [Produces("application/json")]
  [Consumes("application/json")]
  [Route("api/BoardSummaryApi")]
  public class BoardSummaryApiController:Controller
  {
    private BoardSummaryRepository _repository;
    public BoardSummaryApiController()
    {
      _repository = new BoardSummaryRepository();
    }
    [HttpGet]
    public IEnumerable<BoardSummaryModel> Get()
    {
      return _repository.GetAll();
    }
    [HttpGet("{alias}", Name ="Get")]
    public IEnumerable<BoardSummaryModel> Get(string alias)
    {
      return _repository.GetByAlias(alias);
    }
  }
  public class BoardSummaryDemoController : Controller
  {
    public IActionResult Index()
    {
      string html = @"
<div id='print'></div>
<script src='https://code.jquery.com/jquery-2.2.4.min.js'></script>
<script>
$(function() {
  $.getJSON('/api/BoardSummaryApi', function(data) {
    var str = '<dl>';

    $.each(data, function (index, entry) {
      str += '<dt>' + entry.title + '</dt><dd>' + entry.name + '</dd>';
    });

    str += '</dl>';
    $('#print').html(str);
  });
});
</script>
";
      ContentResult cr = new ContentResult()
      {
        ContentType = "text/html",
        Content = html
      };
      return cr;
    }
  }
}
