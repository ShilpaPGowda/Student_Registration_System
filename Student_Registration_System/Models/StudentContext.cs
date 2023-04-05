using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Student_Registration_System.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Hobbies> Hobby { get; set; }
    }
}
