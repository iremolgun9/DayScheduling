using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using JsAction;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            //routes.MapRoute(
            //    name: "isLoginSuccess",
            //    url: "Home/isLoginSuccess/{email}/{pass}",
            //    defaults: new { controller = "Home", action = "isLoginSuccess", email = "", pass = "" }
            //    );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
