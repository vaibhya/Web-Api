using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiCRUDCoreLib.Data;
using WebApiCRUDCoreLib.Service;

namespace WebApiOperationApp.Controllers
{
    [RoutePrefix("api/v1")]
    public class HomeController: ApiController
    {
        private WebApiService _service;
        public HomeController()
        {
            //_service = service;
            _service = new WebApiService();
        }
        [Route("Get")]
        public IHttpActionResult Get()
        {
            //WebApiService service = new WebApiService();
            List<Employee> emp = _service.GetEmployees();
            return Json(emp);
        }
        [Route("Get/{id}")]
        public IHttpActionResult Get(string id)
        {
            Employee emp = _service.GetEmployee(id);
            return Ok(emp);
        }
        [Route("Post")]
        public IHttpActionResult Post( Employee emp)
        {
            emp.Id = Guid.NewGuid().ToString();
            _service.PostEmp(emp);
            return Ok(emp.Id);
        }
        [Route("Put/{id}")]
        public IHttpActionResult Put(string id,Employee emp)
        {
            var employee = _service.GetEmployee(id);
            emp.Id = id;
            if (employee == null)
            {
                return BadRequest("Emp not found");
            }
            _service.UpdateEmployee(emp);
            return Ok("Emp Updated ");
        }
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(string id)
        {
            var emp = _service.GetEmployee(id);
            if (emp == null)
            {
                return BadRequest();
            }
            _service.Delete(emp);
            return Ok("Employee Deleted!");
        }

    }
}