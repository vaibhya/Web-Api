using System.Collections.Generic;
using WebApiCRUDCoreLib.Data;

namespace WebApiCRUDCoreLib.Repository
{
    public interface IWebApiRepository
    {
        void Add(Employee emp);
        Employee Get(string id);
        void Remove(Employee emp);
        List<Employee> GetList();
        void Post(Employee emp);
        void Update(Employee emp);
        void Delete(Employee emp);
    }
}