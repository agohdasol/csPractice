using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using DevUser.Repositories;

namespace DevUser
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
      var userRepo = new UserRepository();
      if(userRepo.IsCorrectUser(TxtUserID.Text, TxtPassword.Text))
      {
        if (!string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
          FormsAuthentication.RedirectFromLoginPage(TxtUserID.Text, false);
        else
        {
          FormsAuthentication.SetAuthCookie(TxtUserID.Text, false);
          Response.Redirect("~/Welcome.aspx");
        }
      }
      else
      {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "showMsg", "<script>alert('잘못된 사용자입니다');</script>");
      }
    }
  }
}