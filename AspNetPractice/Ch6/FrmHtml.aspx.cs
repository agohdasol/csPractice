using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch6
{
    public partial class FrmHtml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LitTest.Text = "바꾸기";
        }
    }
}