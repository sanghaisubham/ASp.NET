//Routing plays important role in MVC framework. 
//Routing maps URL to physical file or class (controller class in MVC). 
//Route contains URL pattern and handler information. 
//URL pattern starts after domain name. 
//Routes can be configured in RouteConfig class
// Multiple custom routes can also be configured. 
//Route constraints applies restrictions on the value of parameters. 
//Route must be registered in Application_Start event in Global.ascx.cs file. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
/*MVC framework evaluates each route in sequence.
 * It starts with first configured route and if incoming url doesn't satisfy 
 * the URL pattern of the route then it will evaluate second route and so on.
 Here,routing engine will evaluate Student route first and if incoming url doesn't
 starts with /students then only it will consider second route which is 
 default route.*/
namespace MVC_Example
{
    public class RouteConfig
    {
        //We can configure  routes using MapRoute
        //MapRoute is a method of RouteCollection. 
        //This RouteCollection is actually a property of RouteTable class.
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//Route to ignore
            /* We can also configure a custom route using MapRoute extension method. 
             * We need to provide at least two parameters in MapRoute, route name and url pattern. 
             * The Defaults parameter is optional. */
            routes.MapRoute(
            name: "Student",
            url: "student/{id}",
            defaults: new { controller = "Student", action = "Index" }
            );
            /* We haven't specified {action} in the URL pattern because we want every URL
             * that starts with student should always use Index action of StudentController. 
             * We have specified default controller and action to handle any URL request
             * which starts from domainname/students. */

            routes.MapRoute(
                name: "Default",//Route Name
                url: "{controller}/{action}/{id}",//Url pattern
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//Defaults for route
            );
            /*We can also apply restrictions on the value of parameter by configuring route constraints.*/
            //    routes.MapRoute(
            //name: "Student",
            //url: "student/{id}/{name}/{standardId}",
            //defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, standardId = UrlParameter.Optional },
            
            //constraints: new { id = @"\d+" }
            //the following route applies a restriction on id parameter that the value of an id must be numeric. 
            
            //);
            //So if we give non-numeric value for id parameter then that request will be handled by another route or, if there are no matching routes then "The resource could not be found" error will be thrown. 
        }
    }
}
//Now, after configuring all the routes in RouteConfig class, 
//we need to register it in the Application_Start() event in the Global.asax. 
//So that it includes all our routes into RouteTable.