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
        newdbEntities context;
        public RESTController()
        {
            context = new newdbEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }
        [Route("GetAll")]  //Attribute based route
        public List<emp> Get()
        {
            var result = context.emps.ToList();
            return result;
        }

        [Route("GetOne/{id}")]
        public emp Get(int id)
        {
            
            emp em = context.emps.SingleOrDefault(c => c.code == id);
            return em;
        }

        [Route("AddEmp")]
        public HttpResponseMessage Post([FromBody]emp em)
        {
            context.emps.Add(em);
            context.SaveChanges();
            HttpResponseMessage message = new HttpResponseMessage();
            message.ReasonPhrase = "Created..";
            return message;

        }

        // PUT: api/REST/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/REST/5
        public void Delete(int id)
        {
        }
    }
}
