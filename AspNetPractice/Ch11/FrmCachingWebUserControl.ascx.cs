using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch11
{
    public partial class FrmCachingWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblTimeWebUserControl.Text = DateTime.Now.ToString();
        }
    }
}