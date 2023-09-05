using Microsoft.EntityFrameworkCore;
using AppSantiago.Models;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace AppSantiago.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {


        }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
