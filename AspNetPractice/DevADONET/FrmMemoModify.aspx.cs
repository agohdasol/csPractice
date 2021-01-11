using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DevADONET.Models;

namespace DevADONET
{
  public partial class FrmMemoModify : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(Request["Num"]))
      {
        Response.Write("잘못된 요청입니다.");
        Response.End();
      }
      else
      {
        if (!Page.IsPostBack)
          DisplayData();
      }
    }
    private void DisplayData()
    {
      SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
      con.Open();
      SqlCommand cmd = new SqlCommand("ViewMemo", con);
      cmd.CommandType = System.Data.CommandType.StoredProcedure;

      cmd.Parameters.Add("Num", SqlDbType.Int);
      cmd.Parameters["Num"].Value = Convert.ToInt32(Request["Num"]);

      SqlDataReader dr = cmd.ExecuteReader();
      if (dr.Read())
      {
        this.LblNum.Text = Request["Num"];
        this.TxtName.Text = dr["Name"].ToString();
        this.TxtEmail.Text = dr[2].ToString();
        this.TxtTitle.Text = dr.GetString(3);
      }
      else
      {
        Response.Write("없는 데이터입니다.");
        Response.End();
      }
      dr.Close();
      con.Close();
    }
    protected void BtnModify_Click(object sender, EventArgs e)
    {
      Memo memo = new Memo();
      memo.Num = Convert.ToInt32(Request["Num"]);
      memo.Name = TxtName.Text;
      memo.Email = TxtEmail.Text;
      memo.Title = TxtTitle.Text;

      SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
      con.Open();

      SqlCommand cmd = new SqlCommand("ModifyMemo", con);
      cmd.CommandType = System.Data.CommandType.StoredProcedure;

      cmd.Parameters.AddWithValue("@Name", memo.Name);
      cmd.Parameters.AddWithValue("@Email", memo.Email);
      cmd.Parameters.AddWithValue("@Title", memo.Title);
      cmd.Parameters.AddWithValue("@Num", memo.Num);

      cmd.ExecuteNonQuery();

      con.Close();
      Response.Redirect("FrmMemoView.aspx?Num=" + Request["Num"]);
    }
    protected void BtnList_Click(object sender, EventArgs e)
    {
      Response.RedirectPermanent("FrmMemoList.aspx");
    }
  }
}