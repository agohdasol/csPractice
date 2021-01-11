using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using DevADONET.Models;

namespace DevADONET
{
  public partial class FrmMemoWrite : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnWrite_Click(object sender, EventArgs e)
    {
      Memo memo = new Memo();
      memo.Name = TxtName.Text;
      memo.Email = TxtEmail.Text;
      memo.Title = TxtTitle.Text;
      memo.PostDate = DateTime.Now;
      memo.PostIp = Request.UserHostAddress;

      SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
      con.Open();

      SqlCommand cmd = new SqlCommand("WriteMemo", con);
      cmd.CommandType = System.Data.CommandType.StoredProcedure;

      cmd.Parameters.AddWithValue("@Name", memo.Name);
      cmd.Parameters.AddWithValue("@Email", memo.Email);
      cmd.Parameters.AddWithValue("@Title", memo.Title);
      cmd.Parameters.AddWithValue("@PostIP", memo.PostIp);

      cmd.ExecuteNonQuery();
      LblDisplay.Text = "저장되었습니다.";
    }
    protected void BtnList_Click(object sender, EventArgs e)
    {
      Response.Redirect("FrmMemoList.aspx");
    }
  }
}