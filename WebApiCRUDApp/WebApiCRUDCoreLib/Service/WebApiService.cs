using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCRUDCoreLib.Data;
using WebApiCRUDCoreLib.Repository;

namespace WebApiCRUDCoreLib.Service
{
    public class WebApiService : IWebApiService
    //public class WebApiService 
    {
        private IWebApiRepository _repo;
        //private WebApiRepository _repo;
        public WebApiService(IWebApiRepository repo)
        {
            _repo = repo;
        }
        public List<Employee> GetEmployees()
        {
            return _repo.GetList();
        }
        public Employee GetEmployee(String id)
        {
            return _repo.Get(id);
        }
        public void PostEmp(Employee emp)
        {
            _repo.Post(emp);
        }
        public void UpdateEmployee(Employee emp)
        {
            _repo.Update(emp);
        }
        public void Delete(Employee emp)
        {
            _repo.Delete(emp);
        }
    }
}
