using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ch14.Models;
using Ch14.Repositories;

namespace Ch14.Repositories
{
  public partial class FrmMaximWrite : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnWrite_Click(object sender, EventArgs e)
    {
      Maxim maxim = new Maxim();
      maxim.Name = TxtName.Text;
      maxim.Content = TxtContent.Text;
      MaximServiceRepository repo = new MaximServiceRepository();
      maxim.Id = repo.AddMaxim(maxim).Id;

      LblDisplay.Text = maxim.Id.ToString() + "번 데이터가 입력되었습니다.";
    }
  }
}