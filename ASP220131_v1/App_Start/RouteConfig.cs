using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP220131_v1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            /*
            routes.MapRoute(
                name: "FilmIdAlapjan",
                url: "Filmek/Szerkesztes/{filmId}",
                defaults: new { controller = "Filmek", action = "Szerkesztes", filmId = 0 }
            );

            routes.MapRoute(
                name: "FilmekMegjelenesSzerint",
                url: "Filmek/Megjelenes/{megjelenesEv}/{megjelenesHonap}",
                defaults: new { controller = "Filmek", action = "Megjelenes" },
                constraints: new {megjelenesEv = @"20152022", megjelenesHonap = @"\d{2}" }
            );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
