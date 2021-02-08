using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiHelloWorld.Controllers
{
  [Route("api/[controller]")]
  public class ApiHelloWorldController : Controller
  {
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "안녕하세여", "반갑습니다" };
    }
    [HttpGet("{id:int}")]
    public string Get(int id)
    {
      return $"넘어온 값 : {id}";
    }
  }
}
