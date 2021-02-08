using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiHelloWorld.Controllers
{
  [Route("api/[controller]")]
  public class ApiHelloWorldWithValueController : Controller
  {
    [HttpGet]
    public IEnumerable<Value> Get()
    {
      return new Value[]
      {
        new Value{Id=1, Text="안녕"},
        new Value{Id=2, Text="ㅁㄴㅇㄴㅁㅇ안녕ㅁ"},
        new Value{Id=3, Text="안ㄴㅇㅁㄴㅇㅁ녕ㄴㅇㅁ"},
      };
    }
    [HttpGet("{id:int}")]
    public Value Get(int id)
    {
      return new Value { Id = id, Text = $"넘어온 값 : {id}" };
    }
    [HttpPost]
    [Produces("application/json", Type = typeof(Value))]
    [Consumes("application/json")]
    public IActionResult Post([FromBody] Value value)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      return CreatedAtAction("Get", new { id = value.Id }, value);
    }
  }
  public class Value
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "Text 속성은 필수 입력값입니다.")]
    public string Text { get; set; }
  }
}
