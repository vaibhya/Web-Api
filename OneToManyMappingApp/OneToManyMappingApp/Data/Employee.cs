using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMappingApp.Data
{
    class Employee
    {
        [Key]
        public int ENo { get; set; }
        public string Ename { get; set; }
        public virtual Dept Dep { get; set; }
    }
}
