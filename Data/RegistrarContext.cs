using Microsoft.EntityFrameworkCore;
using Registrar.Models;

namespace Registrar.Data;

public class RegistrarContext : DbContext
{
    public RegistrarContext(DbContextOptions<RegistrarContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Registration> Registrations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("students");
        modelBuilder.Entity<Course>().ToTable("courses");
        modelBuilder.Entity<Registration>().ToTable("registrations");

        modelBuilder.Entity<Registration>()
            .HasKey(r => new { r.StudentId, r.CourseId });

        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Student)
            .WithMany(s => s.Registrations)
            .HasForeignKey(r => r.StudentId);

        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Course)
            .WithMany(c => c.Registrations)
            .HasForeignKey(r => r.CourseId);
    }
}
