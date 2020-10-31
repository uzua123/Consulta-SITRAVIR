using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace WebConsultaSGTD.Config
{
    public interface ILogService
    {
        void LogError(string errorMessage);
    }
    public sealed class LogService : ILogService
    {
        public LogService()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public void LogError(string errorMessage)
        {
            //System.Diagnostics.Trace.TraceError(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            //System.Diagnostics.Trace.TraceError(errorMessage);

            //Log4net
            ILog ilog = LogManager.GetLogger(GetType());
            ilog.Error(string.Format("Request.Url: {0}", OffendingUrl));
            ilog.Error(string.Format("Navigator|Version : {0}", OffendingBrowser));
            ilog.Error(errorMessage);

        }
        private string OffendingUrl
        {
            get {
                return HttpContext.Current.Request.Url.AbsolutePath;
            }
        }

        private string OffendingBrowser
        {
            get
            {
                return HttpContext.Current.Request.Browser.Type;
            }
        }
    }
}