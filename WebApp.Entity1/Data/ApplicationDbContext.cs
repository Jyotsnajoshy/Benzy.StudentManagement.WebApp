using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benzy.StudentManagement.WebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Entity1.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Enrollments>()
                .HasOne(e => e.Grades)
                .WithOne(g => g.Enrollments)
                .HasForeignKey<Grades>(g => g.EnrollmentId);
            modelBuilder.Entity<Enrollments>()
    .HasKey(e => new { e.StudentId, e.CourseId });

            modelBuilder.Entity<Grades>()
                .HasOne(g => g.Enrollments)
                .WithOne(e => e.Grades)
                .HasForeignKey<Grades>(g => new { g.StudentId, g.CourseId });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
