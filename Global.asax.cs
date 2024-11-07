using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using webapitemplate.utilities;

namespace webapitemplate
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private static readonly Serilog.ILogger log = SerilogHelper._log;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            log.Error("log.Error");
            log.Warning("log.Warning");
            log.Information("log.Information");
            log.Debug("log.Debug");
            log.Verbose("log.Verbose");

            //ARZSWService.ArzSWLog.LogConfig(log);
            //ARZSWService.ArzSWLog.LogInfo("LogInfo");
        }
    }
}
