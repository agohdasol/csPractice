using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ch14.Repositories;

namespace Ch14
{
  public partial class FrmMaximDelete : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
      {
        if (!Page.IsPostBack)
          LblId.Text = Request["Id"];
      }
      else
      {
        Response.Write("잘못된 요청입니다.");
        Response.End();
      }
    }
    protected void BtnDelete_Click(object sender, EventArgs e)
    {
      int id = Convert.ToInt32(Request.QueryString["Id"]);

      MaximServiceRepository repo = new MaximServiceRepository();
      repo.RemoveMaxim(id);

      Response.RedirectPermanent("FrmMaximList.aspx");
    }
  }
}