using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using Service.Business;
using Service.DataAccess;
using Service.DataAccess.EntityModel;
using Service.DataAccess.GenericRepository;

[assembly: OwinStartup(typeof(WebService.Startup))]

namespace WebService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var builder = new ContainerBuilder();

            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //builder.RegisterType<GanttChattBusiness>()
            //       .As<IGanttChattBusiness>()
            //       .InstancePerRequest();

            //builder.RegisterType<DbFactory>()
            //       .As<IDbFactory>()
            //       .InstancePerRequest();

            //builder.RegisterGeneric(typeof(GenericRepository<>))
            //       .As(typeof(IGenericRepository<>))
            //       .InstancePerRequest();

            ////Set the dependency resolver to be Autofac.  
           
            //var container = builder.Build();
            //app.UseAutofacMiddleware(container);
        }





    }
}
