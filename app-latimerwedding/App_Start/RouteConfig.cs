using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace app_latimerwedding
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Him",
                url: "Him/{id}",
                defaults: new { controller = "Home", action = "Him", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Her",
                url: "Her/{id}",
                defaults: new { controller = "Home", action = "Her", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Gallery",
                url: "Gallery/{id}",
                defaults: new { controller = "Home", action = "Gallery", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Location",
                url: "Location/{id}",
                defaults: new { controller = "Home", action = "Location", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Registry",
                url: "Registry/{id}",
                defaults: new { controller = "Home", action = "Registry", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Rsvp",
                url: "Rsvp/{id}",
                defaults: new { controller = "Home", action = "Rsvp", id = UrlParameter.Optional }
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
