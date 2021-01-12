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
  public partial class FrmMaximModify : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
      {
        if (!Page.IsPostBack)
          DisplayData();
      }
      else
      {
        Response.Write("잘못된 요청입니다.");
        Response.End();
      }
    }
    private void DisplayData()
    {
      int id = Convert.ToInt32(Request.QueryString["Id"]);

      MaximServiceRepository repo = new MaximServiceRepository();
      Maxim maxim = repo.GetMaximById(id);

      this.LblId.Text = id.ToString();
      this.TxtName.Text = maxim.Name;
      this.TxtContent.Text = maxim.Content;
    }
    protected void BtnModify_Click(object sender, EventArgs e)
    {
      Maxim maxim = new Maxim();

      maxim.Id = Convert.ToInt32(Request.QueryString["Id"]);
      maxim.Name = TxtName.Text;
      maxim.Content = TxtContent.Text;

      MaximServiceRepository repo = new MaximServiceRepository();
      maxim = repo.UpdateMaxim(maxim);

      LblDisplay.Text = maxim.Id.ToString() + "번 데이터가 수정되었습니다.";

      DisplayData();
    }
  }
}