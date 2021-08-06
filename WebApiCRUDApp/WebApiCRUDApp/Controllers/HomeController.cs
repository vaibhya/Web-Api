using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiCRUDCoreLib.Data;
using WebApiCRUDCoreLib.Service;

namespace WebApiCRUDApp.Controllers
{
    [RoutePrefix("api/v1")]
    public class HomeController : ApiController
    {
        private IWebApiService _service;
        public HomeController(IWebApiService service)
        {
            _service = service;
            //_service = new WebApiService();
        }
        [Route("Get")]
        public IHttpActionResult Get()
        {
            //WebApiService service = new WebApiService();
            List<Employee> emp = _service.GetEmployees();
            return Json(emp);
        }
        //public IHttpActionResult Put()
        //{

        //}
        //public IHttpActionResult Delete()
        //{

        //}
        //public IHttpActionResult Post()
        //{

        //}
    }
}