using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;
using System.Web.Mvc;
using System.Web.Routing;

namespace SpaBookingSYstemMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
