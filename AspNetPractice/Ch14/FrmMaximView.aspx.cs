using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ch14.Models;
using Ch14.Repositories;

namespace Ch14
{
  public partial class FrmMaximView : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
        DisplayData();
    }
    private void DisplayData()
    {
      int id = Convert.ToInt32(Request.QueryString["Id"]);

      MaximServiceRepository repo = new MaximServiceRepository();
      Maxim maxim = repo.GetMaximById(id);

      this.LblId.Text = id.ToString();
      this.LblName.Text = maxim.Name;
      this.LblContent.Text = maxim.Content;

      this.BtnModify.NavigateUrl = "FrmMaximModify.aspx?Id=" + id;
      this.BtnDelete.NavigateUrl = "FrmMaximDelete.aspx?Id=" + id;
    }
  }
}