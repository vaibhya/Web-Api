using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCoreLibrary.Data
{
    public class Exhibition
    {
        [Key]
        public string Eid { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Organizer Oid { get; set; }
    }
}
