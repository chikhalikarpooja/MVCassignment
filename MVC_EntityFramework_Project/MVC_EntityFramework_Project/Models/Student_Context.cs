using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVC_EntityFramework_Project.Models
{
    public class Student_Context : DbContext
    {
        public Student_Context() : base("StudentDatabase")
        {
        }
        public DbSet<student> Students{ get; set; }

    }
}