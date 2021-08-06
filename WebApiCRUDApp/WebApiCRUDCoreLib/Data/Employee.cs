﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCRUDCoreLib.Data
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool isMale { get; set; }
        public string Date { get; set; }

    }
}
