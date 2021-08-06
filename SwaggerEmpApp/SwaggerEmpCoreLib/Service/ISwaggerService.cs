using SwaggerEmpCoreLib.Data;
using System.Collections.Generic;

namespace SwaggerEmpCoreLib.Service
{
    public interface ISwaggerService
    {
        void Delete(Employee emp);
        Employee GetEmployee(string id);
        List<Employee> GetEmployees();
        void PostEmp(Employee emp);
        void UpdateEmployee(Employee emp);
    }
}