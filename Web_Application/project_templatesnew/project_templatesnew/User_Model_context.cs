namespace project_templatesnew
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class User_Model_context : DbContext
    {
        public User_Model_context()
            : base("name=User_Model")
        {
        }

        public virtual DbSet<New_User_Reg> New_User_Reg { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
