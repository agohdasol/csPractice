using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch3
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserID = string.Empty;
            string strPassword = string.Empty;
            string strName = string.Empty;
            string strAge = string.Empty;

            strUserID = Request.QueryString["UserID"];
            strPassword = Request.Params["Password"];
            strName = Request.Form["Name"];
            strAge = Request["Age"];

            string strMsg = string.Format(
                "입력하신 아이디는 {0}이고<br />"
                + "암호는 {1}이고<br />"
                + "이름은 {2}이고<br />"
                + "나이는 {3}입니다<br />",
                strUserID, strPassword, strName, strAge);

            Response.Write(strMsg);
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            int age = Convert.ToInt32(Age.Text);
        }
    }
}