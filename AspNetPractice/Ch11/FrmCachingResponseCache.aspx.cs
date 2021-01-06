using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch11
{
    public partial class FrmCachingResponseCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(DateTime.Now.ToString());
            Response.Cache.SetCacheability(HttpCacheability.Public);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
            Response.Cache.VaryByParams["*"] = true;
        }
    }
}