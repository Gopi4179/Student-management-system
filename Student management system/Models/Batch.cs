using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_management_system.Models
{
    [Table("Batch")]
    public class Batch
    {
        [Key]
        public int id { get; set; }
        public string  batch { get; set; }
        public string year { get; set; }
    }
}