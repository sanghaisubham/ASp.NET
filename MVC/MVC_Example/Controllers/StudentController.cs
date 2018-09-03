/*
 * MVC framework routing engine uses Action Selectors attributes to determine which action method to invoke. 
 * Three action selectors attributes are available in MVC 5
   - ActionName
   - NonAction
   - ActionVerbs
 * ActionName attribute is used to specify different name of action than method name.
 * NonAction attribute marks the public method of controller class as non-action method. It cannot be invoked. 
 * The ActionVerbs selector is used when we want to control the selection of an action method 
 *    based on a Http request method. 
 * For example, we can define two different action methods with the same name 
 *    but one action method responds to an HTTP Get request 
 *    and another action method responds to an HTTP Post request. 
 */
using MVC_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>(){
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                        };
        public ActionResult Index()//ActionResult is the return type
                             //Index() is action method
        {
            
            return View(studentList);
        }
        // GET: Student
        public string Index1()//string is the return type
            //Index() is action method
        {
            return "This is Index action method of StudentController";
        }
        //ActionName attribute allows us to specify a different action name than the method name.
        //action name is "find" instead of "GetById".
        //This action method will be invoked on http://localhost/student/find/1 request 
        //instead of http://localhost/student/getbyid/1 request. 
        [ActionName("find")]
        public ActionResult GetById(int id)
        {
            // get student from the database 
            return View();
        }
        //NonAction selector attribute indicates that a public method of a Controller is not an action method.
        //[NonAction]
        //public Student GetStudnet(int id)
        //{
        //    return studentList.Where(s => s.StudentId == id).FirstOrDefault();
        //}

        /*
         * we use the Request.QueryString and Request (Request.Form) object 
         * to get the value from HttpGet and HttpPOST request.
         */
        //Student/Edit?id=1
        [HttpGet]
        public ActionResult Edit(int id)
        {
            /*Used a LINQ query to get the Student from the sample studentList 
             * collection whose StudentId matches with supplied StudentId, 
             * and then we inject that Student object into View.
             */
            //fetching info from DB
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            //retrieve data from Database
            return View(std);
        }
        //With model binding, MVC framework converts the http request values
        //(from query string or form collection) to action method parameters.
        //Student/Edit
        [HttpPost]
        public ActionResult Edit(Student std)
        {
           
            var name = std.StudentName;
            var age = std.Age;
            //update Database
            return RedirectToAction("Index");
        }


        [HttpPut]
        public ActionResult PutAction()
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }
        //also apply multiple http verbs using AcceptVerbs attribute.
        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetAndPostAction()
        {
            return RedirectToAction("Index");
        }
    }
}