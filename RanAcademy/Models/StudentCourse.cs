using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RanAcademy.Models
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
        
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}