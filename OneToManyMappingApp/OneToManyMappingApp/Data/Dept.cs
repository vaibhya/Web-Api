using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMappingApp.Data
{
    class Dept
    {
        [Key]
        public int DeptNo { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }
        //public Employee Employee { get; set; }
    }
}
