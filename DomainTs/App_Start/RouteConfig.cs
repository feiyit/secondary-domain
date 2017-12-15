using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DomainTs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/

            routes.Add(
            "domtest", new DomainRoute(
            "domtest.com",
            "{controller}/{action}/{id}",
            new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          ));
            routes.Add(
             "wwwDomainRoute", new DomainRoute(
             "www.domtest.com",
             "{controller}/{action}/{id}",
             new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           ));
            routes.Add(
               "DomainRoute", new DomainRoute(
               "{CityNameUrl}.domtest.com",
               "{controller}/{action}/{id}",
            new { CityNameUrl = "", controller = "City", action = "Index", id = "" }
            ));
        }
    }
}
