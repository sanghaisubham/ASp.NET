using MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult GetAllEmps()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56672/");
            HttpResponseMessage message= client.GetAsync("GetAll").Result;
            string data = "";
            List<emp> list=null;
            if(message.IsSuccessStatusCode)
            {
                data = message.Content.ReadAsStringAsync().Result;
                list=JsonConvert.DeserializeObject<List<emp>>(data);
            }
            return View(list);
        }

        public async Task<ActionResult> GetAllEmps2()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56672/");
            HttpResponseMessage message =await client.GetAsync("GetAll");
            string data = "";
            List<emp> list = null;
            if (message.IsSuccessStatusCode)
            {
                data = await message.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<emp>>(data);
            }
            return View(list);
        }
        public ActionResult Add()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56672/");
            emp em = new emp() { code=66,name="Maggie",salary=4500,deptid=101 };
            string data=JsonConvert.SerializeObject(em);

            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage message = client.PostAsync("AddEmp", content).Result;
            object messageFromService=null;
            if (message.IsSuccessStatusCode)
            {
                messageFromService= message.ReasonPhrase;
            }
            return View(messageFromService);
        }

    }
}