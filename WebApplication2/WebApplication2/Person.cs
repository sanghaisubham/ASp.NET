using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    [Serializable]
    //Serializable objects enables objects of class to be broken into bytes that can be transmitted over network
    
    public class Person
    {
        public string name;
        public int age;
    }
}