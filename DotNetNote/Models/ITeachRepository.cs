using System.Collections.Generic;

namespace DotNetNote.Models
{
  public interface ITeachRepository
  {
    void AddTeach(Teach model);
    List<Teach> GetTeaches();
  }
}
