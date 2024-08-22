using Microsoft.EntityFrameworkCore;
using Registrar.Models;

namespace Registrar.Data
{
    public class RegistrarContext : DbContext
    {
        public RegistrarContext(DbContextOptions<RegistrarContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Student>()
        .HasKey(s => s.Id);

    modelBuilder.Entity<Course>()
        .HasKey(c => c.Id);

    modelBuilder.Entity<Registration>()
        .HasKey(r => new { r.StudentId, r.CourseId });

    modelBuilder.Entity<Registration>()
        .HasOne<Student>()
        .WithMany()
        .HasForeignKey(r => r.StudentId);

    modelBuilder.Entity<Registration>()
        .HasOne<Course>()
        .WithMany()
        .HasForeignKey(r => r.CourseId);
}

    }
}
