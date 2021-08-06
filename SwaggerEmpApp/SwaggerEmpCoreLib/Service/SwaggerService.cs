using SwaggerEmpCoreLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwaggerEmpCoreLib.Repository;

namespace SwaggerEmpCoreLib.Service
{
    public class SwaggerRepository : ISwaggerService
    {
        //private IWebApiRepository _repo;
        private SwaggerRepository _repo;
        public SwaggerRepository()
        {
            _repo = new SwaggerRepository();
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
