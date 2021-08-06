using SwaggerEmpCoreLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerEmpCoreLib.Repository

{
    public class SwaggerRepository : ISwaggerRepository
    {
        static List<Employee> _empList = new List<Employee>();
        //private static WebApiRepository instance = null;
        public SwaggerRepository()
        {
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "atul", Location = "Nerul" });
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "vaibhav", Location = "virar" });
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "vishal", Location = "vasai" });
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "amruta", Location = "bhayandar" });
        }

        public List<Employee> GetList() { return _empList; }
        public void Add(Employee emp)
        {
            _empList.Add(emp);
        }
        public Employee Get(string id)
        {
            Employee emp = null;
            foreach (var employee in _empList)
            {
                if (employee.Id == id)
                {
                    emp = employee;
                }
            }
            return emp;
        }
        public void Remove(Employee emp)
        {
            _empList.Remove(emp);
        }
        public void Post(Employee emp)
        {
            _empList.Add(emp);
        }
        public void Update(Employee emp)
        {
            string empid = emp.Id;
            int index = _empList.FindIndex(e => e.Id == emp.Id);
            //Debug.WriteLine(index);
            _empList[index] = emp;
        }
        public void Delete(Employee emp)
        {
            _empList.Remove(emp);
        }
    }
}
