using Autofac;
using Autofac.Integration.WebApi;
using Service.Business;
using Service.DataAccess;
using Service.DataAccess.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace WebService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IContainer Container;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Bootstrapper.Run();
            GlobalConfiguration.Configure(WebApiConfig.Register);
          
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
        }

       


    }
}
