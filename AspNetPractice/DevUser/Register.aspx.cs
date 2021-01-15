using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevUser.Repositories;

namespace DevUser
{
  public partial class Register : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnRegister_Click(object sender, EventArgs e)
    {
      var userRepo = new UserRepository();
      userRepo.AddUser(TxtUserID.Text, TxtPassword.Text);

      string strJs = "<script>alert('가입완료');location.href='Default.aspx';</script>";
      Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "goDefault", strJs);
    }
  }
}