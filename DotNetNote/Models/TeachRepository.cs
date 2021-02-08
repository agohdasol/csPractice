using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DotNetNote.Models
{
  public class TeachRepository:ITeachRepository
  {
    private IConfiguration _config;
    private SqlConnection db;

    public TeachRepository(IConfiguration config)
    {
      _config = config;
      db = new SqlConnection(_config.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
    }
    public void AddTeach(Teach model)
    {
      string sql = "Insert Into Teaches (Title) Values (@Title)";
      var id = this.db.Execute(sql, model);
    }
    public List<Teach> GetTeaches()
    {
      string sql = "Select Id, Title From Teaches Order By Id Asc";
      return this.db.Query<Teach>(sql).ToList();
    }
  }
}
