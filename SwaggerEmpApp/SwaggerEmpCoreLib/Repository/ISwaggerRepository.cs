using SwaggerEmpCoreLib.Data;
using System.Collections.Generic;

namespace SwaggerEmpCoreLib.Repository
{
    public interface ISwaggerRepository
    {
        void Add(Employee emp);
        void Delete(Employee emp);
        Employee Get(string id);
        List<Employee> GetList();
        void Post(Employee emp);
        void Remove(Employee emp);
        void Update(Employee emp);
    }
}