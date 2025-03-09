using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Progress> ProgressRecords { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Additional Fluent configuration (if needed)
        base.OnModelCreating(modelBuilder);
    }
}
