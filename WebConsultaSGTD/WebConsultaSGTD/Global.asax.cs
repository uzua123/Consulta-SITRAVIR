using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebConsultaSGTD.Config;

namespace WebConsultaSGTD
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error()
        {
            Exception ex = this.Server.GetLastError();
            ILogService logService = new LogService();
            //logService.LogError(string.Format("Request.Url:{0}", Request.Url));
            //logService.LogError(string.Format("Host del Usuario:{0}", Request.UserHostAddress));
            ////Request.ServerVariables

            logService.LogError(ex.ToString());

        }
    }
}
