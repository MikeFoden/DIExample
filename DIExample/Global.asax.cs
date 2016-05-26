using DIExample.Library.Data;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DIExample
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Make sure we have a database set up ready to use.
            System.Data.Entity.Database.SetInitializer(new SeedData());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Autofac and Automapper configurations
            Bootstrapper.Run();
        }
    }
}
