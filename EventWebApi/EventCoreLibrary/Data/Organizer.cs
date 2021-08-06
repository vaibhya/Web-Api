using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCoreLibrary.Data
{
    public class Organizer
    {
        [Key]
        public string Oid { get; set; }
        public string Ename { get; set; }
    }
}
