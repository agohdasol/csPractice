using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch3
{
    public partial class FrmResponseWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("안녕하세요 페이지로드");
        }
        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write("<span style='color:blue;'>반갑습니다 버튼클릭시 span추가</span><br />");
        }
        protected void btnJavaScript_Click(object sender, EventArgs e)
        {
            string strJs = @"
                <script language='JavaScript'>
                    window.alert('안녕');
                </script>
                ";
            Response.Write(strJs);
        }
    }
}