using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch6
{
    public partial class FrmHyperLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LnkDotNetKorea.AccessKey = "D";
        }
        protected void BtnChange_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Second % 2 == 0)
                ImgChange.ImageUrl = "~/images/1.jpg";
            else
                ImgChange.ImageUrl = "~/images/2.jpg";
        }
    }
}