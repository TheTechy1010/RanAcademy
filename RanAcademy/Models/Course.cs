using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RanAcademy.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public string Thumbnail { get; set; } 

        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}