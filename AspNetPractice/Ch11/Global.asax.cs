using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Ch11
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Now"] = DateTime.Now;
            Application["CurrentVisit"] = 0;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Now"] = DateTime.Now;
            Application.Lock();
            Application["CurrentVisit"] = (int)Application["CurrentVisit"] + 1;
            Application.UnLock();
        }
        protected void Sessoion_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["CurrentVisit"] = (int)Application["CurrentVisit"] - 1;
            Application.UnLock();
        }
        protected void Application_End(object sender, EventArgs e)
        {

        }
        protected void Application_Error(object sender, EventArgs e)
        {

        }
    }
}