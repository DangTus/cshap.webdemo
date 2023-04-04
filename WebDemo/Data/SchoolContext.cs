using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace WebDemo.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<Student316> Students { get; set; }
        public DbSet<Enrollment316> Enrollments { get; set; }
        public DbSet<Course316> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course316>().ToTable("Course");
            modelBuilder.Entity<Enrollment316>().ToTable("Enrollment");
            modelBuilder.Entity<Student316>().ToTable("Student");
        }
    }
}
