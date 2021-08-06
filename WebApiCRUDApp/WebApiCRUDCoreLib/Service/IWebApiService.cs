using System.Collections.Generic;
using WebApiCRUDCoreLib.Data;

namespace WebApiCRUDCoreLib.Service
{
    public interface IWebApiService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(string id);
        void PostEmp(Employee emp);
        void UpdateEmployee(Employee emp);
        void Delete(Employee emp);
    }
}