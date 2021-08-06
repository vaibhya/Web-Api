using OneToManyMappingApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMappingApp.Model
{
    class AurionProDbContext : DbContext
    {
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }

        public void AddEmp(Employee emp)
        {
            Employee.Add(emp);
            //this.SaveChanges();
        }
        public void AddDept(Dept dept)
        {
            Dept.Add(dept);
            //this.SaveChanges();
        }
        public Dept Find(Dept dept)
        {
            var result = Dept.Find(dept);
            return result;
        }
    }
}
