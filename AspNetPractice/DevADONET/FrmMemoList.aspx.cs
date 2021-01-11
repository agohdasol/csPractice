using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevADONET
{
  public partial class FrmMemoList : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
      con.Open();

      SqlCommand cmd = new SqlCommand("ListMemo", con);
      cmd.CommandType = System.Data.CommandType.StoredProcedure;

      SqlDataAdapter da = new SqlDataAdapter(cmd);

      DataSet ds = new DataSet();
      da.Fill(ds, "Memos");

      CtlMemoList.DataSource = ds;
      CtlMemoList.DataBind();

      con.Close();
    }
  }
}