using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student_management_system.Models
{
    public class cs:DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Batch> Batchdb { get; set; }
        public DbSet<Registation> Registationdb { get; set; }
        public DbSet<User> Userdb { get; set; }
       
    }
}