using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiCRUDCoreLib.Data;
using WebApiCRUDCoreLib.Service;

namespace SwaggerEmpApp.Controllers
{
    [RoutePrefix("api/v1/aurionpro")]
    public class HomeController : ApiController
    {
        private IWebApiService _service;
        public HomeController(IWebApiService service)
        {
            _service = service;
            //_service = new WebApiService();
        }
        [Route("Employee/Get")]
        public IHttpActionResult Get()
        {
            //WebApiService service = new WebApiService();
            List<Employee> emp = _service.GetEmployees();
            return Json(emp);
        }
        [Route("Employee/Get/{id}")]
        public IHttpActionResult Get(string id)
        {
            Employee emp = _service.GetEmployee(id);
            return Ok(emp);
        }
        [Route("Add/Employee/Post")]
        public IHttpActionResult Post(Employee emp)
        {
            emp.Id = Guid.NewGuid().ToString();
            _service.PostEmp(emp);
            return Ok(emp.Id);
        }
        [Route("Update/Employee/{id}")]
        public IHttpActionResult Put(string id, Employee emp)
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
        [Route("Remove/Employee/{id}")]
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