using log4net.Config;
using System;
using System.Web.Http;
using NHibernateImp;

namespace LiftAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected SessionHelper _sessionHelper = null;
        protected void Application_Start()
        {
            HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
            // start log4net
            XmlConfigurator.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            WebApiConfig.BootstrapDi();
        }

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    _sessionHelper = new SessionHelper();
        //    _sessionHelper.OpenSession();
        //}

        //protected void Application_EndRequest(object sender, EventArgs e)
        //{
        //    _sessionHelper = new SessionHelper();
        //    _sessionHelper.CloseSession();
        //}
    }
}
