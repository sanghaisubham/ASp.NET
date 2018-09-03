/*
 * The Controller in MVC architecture handles any incoming URL request
 * MVC routing sends request to appropriate controller and action method based on URL and configured Routes.
 * Controller is a class, derived from the base class System.Web.Mvc.Controller.
 * Controller class contains public methods called Action methods
 * Controller and its action method handles incoming browser requests, retrieves necessary model data and returns appropriate responses. 
 * Action method must be public. It cannot be private or protected 
 * Action method cannot be overloaded 
 * Action method cannot be a static method. 
 * ActionResult is a base class of all the result type which returns from Action method. 
 * Base Controller class contains methods that returns appropriate result type e.g. View(), Content(), File(), JavaScript() etc. 
 * Action method can include Nullable type parameters.
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}