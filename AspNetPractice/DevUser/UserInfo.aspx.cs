using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevUser.Repositories;

namespace DevUser
{
  public partial class UserInfo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.User.Identity.IsAuthenticated)
        Response.Redirect("~/Login.aspx");

      if (!Page.IsPostBack)
        DisplayData();
    }
    private void DisplayData()
    {
      UserRepository userRepo = new UserRepository();
      var model = userRepo.GetUserByUserId(Page.User.Identity.Name);

      LblID.Text = model.Id.ToString();
      TxtUserID.Text = model.UserId;
      TxtPassword.Text = model.Password;
    }
    protected void BtnModify_Click(object sender, EventArgs e)
    {
      var userRepo = new UserRepository();
      userRepo.ModifyUser(Convert.ToInt32(LblID.Text), TxtUserID.Text, TxtPassword.Text);

      string strJs = "<script>alert('수정완료');location.href='Default.aspx';</script>";
      Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "goDefault", strJs);
    }
  }
}