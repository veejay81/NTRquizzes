using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using NTRsearch.DAL;
using NTRsearch.web.Classes;

namespace NTRsearch.web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            RegisterUnityContainer();
        }

        private void RegisterUnityContainer()
        {
            var container = new UnityContainer();
            container
                // HINT: Example of registering a dependence
                //.RegisterType<IQueryService, QueryService>(new PerThreadLifetimeManager())
                // HINT: There is another one missing!
                //.RegisterType<???,???>(new PerThreadLifetimeManager())
                .RegisterType<IDALContext, DALContext>();
            ControllerBuilder.Current.SetControllerFactory(new MyUnityControllerFactory(container));
        }
    }
}
