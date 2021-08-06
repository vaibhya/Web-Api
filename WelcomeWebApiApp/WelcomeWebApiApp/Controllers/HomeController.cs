using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace WelcomeWebApiApp.Controllers
{
    public class HomeController : ApiController
    {
        // GET: Home
        public IHttpActionResult Get()
        {
            return Json("Get");
        }
        public IHttpActionResult Post()
        {
            return Json("Post");
        }
        public IHttpActionResult Put()
        {
            return Json("Put");
        }
    }
}