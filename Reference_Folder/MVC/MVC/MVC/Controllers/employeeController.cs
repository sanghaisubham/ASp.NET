using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        newdbEntities context;
        public employeeController()
        {
            context = new newdbEntities();
        }
        public ActionResult ShowAll()
        {
            var result=context.emps.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult AddNew()
        {
            emp em = new emp();
            return View(em);
        }
        [HttpPost]
        public ActionResult AddNew(emp em)
        {
            context.emps.Add(em);
            context.SaveChanges();
            return RedirectToAction("ShowAll");
        }
    }
}