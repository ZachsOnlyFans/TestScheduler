using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestScheduler.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Module_Code { get; set; }
        public string Module_Description { get; set; }
        public string Level { get; set; }
    }
}
