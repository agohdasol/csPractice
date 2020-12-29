using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch3
{
    public partial class FrmASPNET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for(int i=0;i<11;i++)
                Response.Write($"새로운문구{i}<br/>");
        }
    }
}