using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EntityFramework_Project.Models
{
    public class student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }

    }
}