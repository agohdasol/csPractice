using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DotNetNote.Models;

namespace DotNetNote.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  public class TeachesApiController : Controller
  {
    private ITeachRepository _repo;
    public TeachesApiController(ITeachRepository repo)
    {
      _repo = repo;
    }
    [HttpGet]
    public IEnumerable<Teach> GetTeach()
    {
      return _repo.GetTeaches();
    }
    [HttpPost]
    public Teach PostTeach([FromBody] Teach teach)
    {
      _repo.AddTeach(teach);
      return teach;
    }
  }
}
