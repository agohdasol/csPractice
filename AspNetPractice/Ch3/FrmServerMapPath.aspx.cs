using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch3
{
    public partial class FrmServerMapPath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = Server.MapPath(".");
            this.Label2.Text = Request.ServerVariables["SCRIPT_NAME"];
        }
    }
}