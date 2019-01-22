using MvcYAT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MySql.Data;
using MySql.Data.MySqlClient;
using MvcYAT.Data;

namespace MvcYAT
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "DefaultRoute",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = "" }
                );
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterRoutes(RouteTable.Routes);

            // Initialize the product database.
            Database.SetInitializer(new DbInitializer());

            ApplicationDbContext con = new ApplicationDbContext();
            
            con.Database.Initialize(false);
            con.Database.CreateIfNotExists();
        }
    }
}
