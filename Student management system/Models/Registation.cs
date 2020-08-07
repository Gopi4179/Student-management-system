using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_management_system.Models
{
    [Table("reg")]
    public class Registation
    {
        [Key]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nic { get; set; }
      
        public int Course_id { get; set; }
       
        public int Batch_id { get; set; }
        public int phone_no { get; set; }
    }
}