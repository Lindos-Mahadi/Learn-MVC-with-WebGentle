using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp_MVC_AllTopics_with_WebGentle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Custom Route Name By MySelf
            routes.MapRoute(
                name: "allStudents",
                url: "students",
                defaults: new {controller = "Students", action = "GetAllStudent" }
            );

            routes.MapRoute(
                name: "getStudent",
                url: "students/{id}",
                defaults: new { controller = "Students", action = "GetStudent" }
                //constraints: new {id = @"\d+"}
            );

            routes.MapRoute(
                name: "AddressStudent",
                url: "students/{id}/StudentAddress",
                defaults: new { controller = "Students", action = "GetStudentAddress" }
            );


            // Custom Route END


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
