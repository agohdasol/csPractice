using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using Ch14.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ch14.Repositories
{
  public class MaximServiceRepository
  {
    private IDbConnection db = new SqlConnection(
      ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public Maxim AddMaxim(Maxim model)
    {
      string sql = @"
        Insert Into Maxims (Name, Content) Values (@Name, @Content);
        Select Cast(SCOPE_IDENTITY() As Int);
      ";
      var id = this.db.Query<int>(sql, model).Single();
      model.Id = id;
      return model;
    }
    public List<Maxim> GetMaxims()
    {
      string sql =
        "Select Id, Name, Content, CreationDate From Maxims Order By Id Asc";
      return this.db.Query<Maxim>(sql).ToList();
    }
    public Maxim GetMaximById(int id)
    {
      string sql = "Select Id, Name, Content, CreationDate From Maxims Where Id=@Id";
      return this.db.Query<Maxim>(sql, new { Id = id }).SingleOrDefault();
    }
    public Maxim UpdateMaxim(Maxim model)
    {
      string sql =
        "Update Maxims Set Name=@Name, Content=@Content Where Id=@Id";
      this.db.Execute(sql, model);
      return model;
    }
    public void RemoveMaxim(int id)
    {
      string sql = "Delete MAxims Where Id=@Id";
      this.db.Execute(sql, new { Id = id });
    }
  }
}