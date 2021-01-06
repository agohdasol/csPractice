using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch11
{
    public partial class FrmStateShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TxtApplication.Text = Application["Now"].ToString();
            this.TxtSession.Text = Session["Now"].ToString();

            if (Cache["Now"] != null)
                this.TxtCache.Text = Cache["Now"].ToString();
            if (Request.Cookies["Now"] != null)
                this.TxtCookies.Text = Server.UrlDecode(Request.Cookies["Now"].Value);
            if (ViewState["Now"] != null)
                this.TxtViewState.Text = ViewState["Now"].ToString();
        }
    }
}