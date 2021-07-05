using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Range(10, 20)]
        public int Age { get; set; }
    }
}