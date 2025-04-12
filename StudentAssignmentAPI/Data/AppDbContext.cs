using Microsoft.EntityFrameworkCore;
using StudentAssignmentAPI.Entities;

namespace StudentAssignmentAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Assignment> Assignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Student>().ToTable("Student");
        
        modelBuilder.Entity<Assignment>().ToTable("Assignment");
        
        
    }
}