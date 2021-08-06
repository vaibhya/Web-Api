using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace WelcomeWebApi2.Controllers
{
    [RoutePrefix("api/v1")]
    public class BrowseController : ApiController
    {
        [Route("Get")]
        public IHttpActionResult Get()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 10);
            if (num > 5)
            {
                return Ok(new
                {
                    Name = "aurionpro",
                    Stringth = "200",
                    Location = "Nerul"

                });

            }
            
            return NotFound();
            //return BadRequest("Bad request");
        }
        public IHttpActionResult Post()
        {
            return Ok("post");
        }
    }
}