/*
 * Model represents domain specific data and business logic in MVC architecture.
 * It maintains the data of the application. Model objects retrieve and store model state in the persistance store like a database.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Example.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        //[Display (Name="Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}