using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DevADONET
{
  public partial class FrmSqlConnection : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
        DisplayData();
      SqlConnection con = new SqlConnection();
      con.ConnectionString = ConfigurationManager.ConnectionStrings[
        "ConnectionString"].ConnectionString;
      con.Open();

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = con;
      cmd.CommandText = @"
        Select Num, Name, Email, Title, PostDate, PostIp
        From Memos
        Order By Num Desc
      ";
      cmd.CommandType = CommandType.Text;

      SqlDataAdapter da = new SqlDataAdapter();
      da.SelectCommand = cmd;
      DataSet ds = new DataSet();
      da.Fill(ds, "Memos");

      CtlMemoLists.DataSource = ds.Tables[0].DefaultView;
      CtlMemoLists.DataBind();

      con.Close();
    }
    protected void BtnSqlConnection_Click(object sender, EventArgs e)
    {
      SqlConnection con = new SqlConnection();
      con.ConnectionString = ConfigurationManager.ConnectionStrings[
        "ConnectionString"].ConnectionString;

      con.Open();

      LblDisplay.Text = "데이터베이스 연결 성공";

      con.Close();
    }
    protected void BtnSqlCommand_Click(object sender, EventArgs e)
    {
      SqlConnection con = new SqlConnection();
      con.ConnectionString = ConfigurationManager.ConnectionStrings[
        "ConnectionString"].ConnectionString;

      con.Open();

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = con;
      cmd.CommandText = @"
        Insert Into Memos
        Values(
        N'홍길동', N'h@h.com', N'홍길동입니다.', GetDate(), '127.0.0.1')
        ";
      cmd.CommandType = CommandType.Text;
      cmd.ExecuteNonQuery();
      LblDisplay.Text = "데이터 저장 완료";

      con.Close();
    }
    private void DisplayData()
    {
      SqlConnection con = new SqlConnection();
      con.ConnectionString = ConfigurationManager.ConnectionStrings[
        "ConnectionString"].ConnectionString;
      con.Open();
      SqlCommand cmd = new SqlCommand();
      cmd.Connection = con;
      cmd.CommandText = @"
        Select Num, Name, Email, Title, PostDate, PostIp
        From Memos
        Order By Num Desc
      ";
      cmd.CommandType = CommandType.Text;

      SqlDataReader dr = cmd.ExecuteReader();

      string strOutput = "<table border=\"1\">" + "<tr><td>번호</td><td>이름</td><td>메모</td><td>작성일</td></tr>";
      while (dr.Read())
      {
        strOutput += $"<tr><td>{dr["Num"]}</td>" +
          $"<td>{dr[1]}</td>" + $"<td>{dr.GetString(3)}</td>" +
          $"<td>{dr.GetDateTime(4).ToShortDateString()}</td></tr>";
      }
      strOutput += "</table>";

      dr.Close();
      TblOutput.Text = strOutput;

      con.Close();
    }
  }
}