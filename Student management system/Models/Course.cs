using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_management_system.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int id { get; set; }
        public string course { get; set; }
        public string Duration { get; set; }


    }
}