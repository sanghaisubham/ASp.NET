using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC.Controllers
{
    public class RESTController : ApiController
    {
        // GET: api/REST
        UHGDBEntities context;
        public RESTController()
        {
            context = new UHGDBEntities();
            //context.Configuration.ProxyCreationEnabled = false;
        }
        [Route("GetAll")]
        public List<emp> Get()
        {
            var result = context.emps.ToList();
            return result;
        }

        // GET: api/REST/5
        [Route("GetOne/{id}")]
        public emp Get(int id)
        {
            //HttpResponseMessage message;
            emp em = context.emps.SingleOrDefault(context => context.code == id);
            //if(em==null)
            //    message=new HttpResponseMessage()
            //    {
            //        ReasonPhrase="Not "
            //    }
            //    else

            //    return Content(HttpStatusCode.OK,em);

            return em;
        }
        [Route("AddEmp")]
        // POST: api/REST
        public HttpResponseMessage Post([FromBody]emp em)
        {
            context.emps.Add(em);
            context.SaveChanges();
            HttpResponseMessage message = new HttpResponseMessage();
            message.ReasonPhrase = "Created..";
            return message;
        }

        // PUT: api/REST/5
        public void Put(int id, [FromBody] int value)
        {
            
        }

        // DELETE: api/REST/5
        public void Delete(int id)
        {
        }
    }
}
