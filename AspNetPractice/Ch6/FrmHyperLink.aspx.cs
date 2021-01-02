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

            TableRow tr = new TableRow();
            TableCell td = new TableCell();
            LiteralControl lc = new LiteralControl();
            lc.Text = "lc안녕";
            td.Controls.Add(lc);
            tr.Cells.Add(td);
            this.CtlMyTable.BorderWidth = 1;
            this.CtlMyTable.Rows.Add(tr);
        }
        protected void BtnChange_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Second % 2 == 0)
                ImgChange.ImageUrl = "~/images/1.jpg";
            else
                ImgChange.ImageUrl = "~/images/2.jpg";
        }
        protected void LstFavorite_Click(object sender, BulletedListEventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("선택한 항목 : <br />");
            sb.Append(LstFavorite.Items[e.Index].Text);
            sb.Append("<br />");
            sb.Append(LstFavorite.Items[e.Index].Value + "<br />");

            Response.Write(sb.ToString());
        }
    }
}