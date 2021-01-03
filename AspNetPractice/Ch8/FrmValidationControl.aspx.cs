using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch8
{
    public partial class FrmValidationControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.SetFocus(TxtUserId);
            }
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Page.ClientScript.RegisterClientScriptBlock(
                    this.GetType(),
                    "alertMessage",
                    "<script>alert('통과');</script>");
            }
        }
    }
}