using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DevADONET
{
  public partial class FrmMemoView : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(Request["Num"]))
      {
        Response.Write("잘못된 요청입니다.");
        Response.End();
      }
      else
      {
        DisplayData();
        LnkMemoModify.NavigateUrl = $"FrmMemoModify.aspx?Num={Request["Num"]}";
        LnkMemoDelete.NavigateUrl = $"FrmMemoDelete.aspx?Num={Request["Num"]}";
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
        this.LblName.Text = dr["Name"].ToString();
        this.LblEmail.Text = dr[2].ToString();
        this.LblTitle.Text = dr.GetString(3);
        this.LblPostDate.Text = dr.GetDateTime(4).ToString();
        this.LblPostIP.Text = dr.GetString(5);
      }
      else
      {
        Response.Write("없는 데이터입니다.");
        Response.End();
      }
      dr.Close();
      con.Close();
    }
  }
}