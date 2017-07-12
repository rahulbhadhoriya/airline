using System;
using System.Web.Http;
using System.Web.Management;
using Airlines.AppStart;

namespace Airlines
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }       
    }
}