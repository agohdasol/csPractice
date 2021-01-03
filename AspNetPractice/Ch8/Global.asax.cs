using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace Ch8
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            System.Web.UI.ValidationSettings.UnobtrusiveValidationMode =
                    System.Web.UI.UnobtrusiveValidationMode.WebForms;
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js"
            });
        }
    }
}