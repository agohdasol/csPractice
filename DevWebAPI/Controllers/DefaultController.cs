using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevWebAPI.Controllers
{
  public class DefaultController : ApiController
  {
    // GET api/<controller>
    public IEnumerable<string> Get()
    {
      return new string[] { "옴뇸뇸", "밍밍밍" };
    }

    // GET api/<controller>/5
    public string Get(int id)
    {
      return "입력한 값" + id.ToString();
    }

    // POST api/<controller>
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
  }
}