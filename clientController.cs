using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

//-----------here is the code for put request and delete request--
//-----add these methods to the web api client class clientcontroller that 
//we used in the class. You the base address of your rest service.
        public ActionResult Update()
        {
            HttpClient client = new HttpClient();
			//--base address of REST service. Use your address.
            client.BaseAddress = new Uri("http://localhost:1166/");
            emp em = new emp() { code = 31, name = "Tom Alter", salary = 2800, deptid = 101 };
            string data=JsonConvert.SerializeObject(em);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage message = client.PutAsync("UpdateEmp", content).Result;
            object ans = null;
            if(message.IsSuccessStatusCode)
            {
                ans = message.ReasonPhrase;
            }
            return View(ans);
        }
        public ActionResult Delete()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1166/");
            string url = string.Format("DeleteEmp/{0}",100);
            HttpResponseMessage message = client.DeleteAsync(url).Result;

            return View((object)message.ReasonPhrase);
            
        }
