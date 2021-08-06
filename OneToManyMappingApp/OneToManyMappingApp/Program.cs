using OneToManyMappingApp.Data;
using OneToManyMappingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMappingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionProDbContext db = new AurionProDbContext();
            
            Dept d1 = new Dept { DeptNo = 1, Dname = "java", Location = "nerul" };
            Dept d2 = new Dept { DeptNo = 2, Dname = ".Net", Location = "vashi" };
            Dept d3 = new Dept { DeptNo = 3, Dname = "python", Location = "vashi" };

            Employee emp1 = new Employee { Ename = "vijay", ENo = 1, Dep = d1 };
            Employee emp2 = new Employee { Ename = "vaibhav", ENo = 2, Dep = d2 };
            Employee emp3 = new Employee { Ename = "atul", ENo = 3, Dep = d3 };
            Employee emp4 = new Employee { Ename = "akash", ENo = 4, Dep = d1 };
            Employee emp5 = new Employee { Ename = "viraj", ENo = 5, Dep = d2 };


            db.AddDept(d1);
            db.AddDept(d2);
            db.AddDept(d3);

            db.AddEmp(emp1);
            db.AddEmp(emp2);
            db.AddEmp(emp3);
            db.AddEmp(emp4);
            db.AddEmp(emp5);

            db.SaveChanges();
            


        }
    }
}
