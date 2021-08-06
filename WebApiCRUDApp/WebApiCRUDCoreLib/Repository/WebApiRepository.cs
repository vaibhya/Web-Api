using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCRUDCoreLib.Data;

namespace WebApiCRUDCoreLib.Repository
{
    public class WebApiRepository : IWebApiRepository
    //public class WebApiRepository 
    {
        List<Employee> _empList = new List<Employee>();
        //private static WebApiRepository instance = null;
        public WebApiRepository()
        {
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "atul", Salary=4000,Age=23,Email="vk75@gmail.com",Date="7 may",isMale = true });
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "vaibhav", Salary = 5000, Age = 22, Email = "sk@gmail.com", Date = "7 may", isMale = true });
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "vishal", Salary = 4500, Age = 24, Email = "vishal@gmail.com", Date = "7 may", isMale = true });
            _empList.Add(new Employee { Id = Guid.NewGuid().ToString(), Name = "amruta", Salary = 6000, Age = 25, Email = "amruta@gmail.com", Date = "7 may", isMale = false });
        }
        
        public List<Employee> GetList() { return _empList; }
        public void Add(Employee emp)
        {
            _empList.Add(emp);
        }
        public Employee Get(string id)
        {
            Employee emp=null;
            foreach(var employee in _empList)
            {
                if (employee.Id == id)
                {
                    emp= employee;
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
            int index= _empList.FindIndex(e => e.Id == emp.Id);
            //Debug.WriteLine(index);
            _empList[index] = emp;
        }
        public void Delete(Employee emp)
        {
            _empList.Remove(emp);
        }
    }
}
