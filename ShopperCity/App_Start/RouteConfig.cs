using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopperCity
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
           name: "Products",
           url: "Products/{id}",
           defaults: new { controller = "Products", action = "Index" }
           );

            routes.MapRoute(
                       name: "Customers",
                       url: "Customers/{id}",
                       defaults: new { controller = "Customers", action = "Index" }
                       );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Orders", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
