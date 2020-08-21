using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RanAcademy.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext():base("name=conn")
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Catagory> Catagories { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
    
}