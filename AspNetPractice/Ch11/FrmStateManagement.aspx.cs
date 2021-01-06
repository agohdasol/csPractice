using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;

namespace Ch11
{
    public partial class FrmStateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.TxtApplication.Text = Application["Now"].ToString();
                this.TxtSession.Text = Session["Now"].ToString();

                if (Cache["Now"] != null)
                    this.TxtCache.Text = Cache["Now"].ToString();
                if (Request.Cookies["Now"] != null)
                    this.TxtCookies.Text = Server.UrlDecode(Request.Cookies["Now"].Value);
                if (ViewState["Now"] != null)
                    this.TxtViewState.Text = ViewState["Now"].ToString();

                LblNow.Text = Application["CurrentVisit"].ToString();
                LblSITE_NAME.Text = WebConfigurationManager.AppSettings["SITE_NAME"].ToString();
                LblCOMPANY_NAME.Text = ConfigurationManager.AppSettings["COMPANY_NAME"].ToString();
                LblASPNETBOOKTEST_ConnectionString.Text = WebConfigurationManager.ConnectionStrings[
                    "ASPNETBOOKTEST_ConnectionString"].ConnectionString;
            }
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Application["Now"] = this.TxtApplication.Text;
            Session["Now"] = this.TxtSession.Text;
            Cache["Now"] = this.TxtCache.Text;
            Response.Cookies["Now"].Value = Server.UrlEncode(TxtCookies.Text);
            ViewState["Now"] = this.TxtViewState.Text;
            Response.Redirect("FrmStateShow.aspx");
        }
    }
}