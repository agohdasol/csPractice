using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmStandardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnHtml.Value = "HTML 서버 컨트롤 - 버튼";
            BtnServer.Text = "표준컨트롤 - 버튼";
            LblDateTime.Text = DateTime.Now.ToString();
            if (!Page.IsPostBack)
                TxtNum.Text = "0";
            this.ImgWrite.ImageUrl = "/images/btn.gif";
            this.ImgList.ImageUrl = "/images/btn.gif";
            this.LblDisplay.ForeColor = System.Drawing.Color.Red;
        }
        protected void BtnOK_Click(object sender, EventArgs e)
        {
            string strName = this.TxtSingleLine.Text;
            string strIntro = this.TxtMultiLine.Text;
            string strPassword = this.TxtPassword.Text;
            Response.Write(strName + "<br />"
                        + strIntro + "<br />"
                        + strPassword + "<br />");
        }
        protected void BtnUp_Click(object sender, EventArgs e)
        {
            TxtNum.Text = Convert.ToString(Convert.ToInt32(TxtNum.Text) + 1);
        }
        protected void BtnDown_Click(object sender, EventArgs e)
        {
            TxtNum.Text = Convert.ToString(Convert.ToInt32(TxtNum.Text) - 1);
        }
        protected void LnkDotNetKorea_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.dotnetkorea.com/");
        }
        protected void ImgWrite_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("글쓰기 클릭<br />");
        }
        protected void ImgList_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("리스트 클릭<br />");
        }

        protected void BtnCommand_Click(object sender, EventArgs e)
        {
            if (sender == BtnButton)
                this.LblDisplay.Text = "버튼 클릭됨";
            else if (sender == BtnLink)
                this.LblDisplay.Text = "링크 클릭됨";
        }
        protected void BtnImage_Click(object sender, ImageClickEventArgs e)
        {
            this.LblDisplay.Text = String.Format(
                "이미지 버튼 클릭됨<br />X좌표:{0}, Y좌표:{1}",
                e.X, e.Y);
            if (e.X > 20 && e.Y > 20)
                Response.Redirect("http://dotnetkorea.com/");
        }
    }
}