using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch3
{
    public partial class FrmResponseRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnDotNetKorea_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.dotnetkorea.com/");
        }
        protected void BtnDevLec_Click(object sender, EventArgs e)
        {
            string strURL = "http://www.devlec.com/";
            Response.Redirect(strURL);
        }
        protected void BtnVisualAcademy_Click(object sender, ImageClickEventArgs e)
        {
            string strURL = String.Format(
                "http://{0}/{1}?{2}={3}",
                "www.visualacademy.com",
                "default.htm",
                "UserID", "RedPlus");
            Response.Redirect(strURL);
        }
    }
}