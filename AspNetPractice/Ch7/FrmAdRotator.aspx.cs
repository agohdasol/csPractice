using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch7
{
    public partial class FrmAdRotator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.SetFocus(TxtMessage);
            }
            this.PnlFirst.Visible = true;
            this.PnlSecond.Visible = false;
            BtnShowPanel1.Visible = false;
            BtnShowPanel2.Visible = true;

            Button btn1 = new Button();
            btn1.ID = "btn1";
            btn1.Text = "버튼 1";
            btn1.Click += btn_Click;
            CtlPlaceHolder.Controls.Add(btn1);

            Literal ltr = new Literal();
            ltr.Text = "<br />";
            CtlPlaceHolder.Controls.Add(ltr);

            Button btn2 = new Button();
            btn2.ID = "btn2";
            btn2.Text = "버튼 2";
            btn2.Click += btn_Click;
            CtlPlaceHolder.Controls.Add(btn2);

        }
        private void btn_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = (sender as Button).Text + " 버튼이 클릭되었습니다<br />";

            Button BtnCurrent = sender as Button;
            LblDisplay.Text += BtnCurrent.ID + " 버튼입니다<br />";
            LblDisplay.Text += ((Button)CtlPlaceHolder.FindControl(BtnCurrent.ID)).Text + " 버튼이겠죠?";
        }
        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            if (CtlFileUpload.HasFile)
            {
                CtlFileUpload.SaveAs(Server.MapPath(".") + "\\files\\" + CtlFileUpload.FileName);
                LblResult.Text = String.Format("<a href='{0}{1}'>{1}</a>", "./files/", Server.UrlEncode(CtlFileUpload.FileName));
            }
        }
        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            string s = "";
            s += this.TxtStart.Text + "<br />";
            s += this.TxtMid.Text + "<br />";
            s += this.TxtFinish.Text + "<br />";
            this.LblComplete.Text = s;
        }
        protected void BtnShowPanel1_Click(object sender, EventArgs e)
        {
            this.PnlFirst.Visible = true;
            this.PnlSecond.Visible = false;
            BtnShowPanel1.Visible = false;
            BtnShowPanel2.Visible = true;
            SetFocus(TxtMessage);
            PnlCommand.DefaultButton = "BtnShowPanel2";
        }
        protected void BtnShowPanel2_Click(object sender, EventArgs e)
        {
            this.PnlFirst.Visible = false;
            this.PnlSecond.Visible = true;
            BtnShowPanel1.Visible = true;
            BtnShowPanel2.Visible = false;
            SetFocus(TxtMessage);
            PnlCommand.DefaultButton = "BtnShowPanel1";
        }
    }
}