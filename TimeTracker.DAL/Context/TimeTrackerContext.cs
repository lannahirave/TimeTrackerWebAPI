using Microsoft.EntityFrameworkCore;
using TimeTracker.DAL.Models;

namespace TimeTracker.DAL.Context;

public class TimeTrackerContext : DbContext
{
    public TimeTrackerContext(DbContextOptions<TimeTrackerContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Project> Projects { get; set; } = null!;
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<EmployeeActivity> Activities { get; set; } = null!;
    public DbSet<ActivityType> ActivityTypes { get; set; } = null!;
    public DbSet<EmployeeRole> EmployeeRoles { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ConfigureContext();
        modelBuilder.SeedData();
    }
}