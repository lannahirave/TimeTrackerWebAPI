using Microsoft.EntityFrameworkCore;
using TimeTracker.DAL.Models;

namespace TimeTracker.DAL.Context;

public class TimeTrackerContext : DbContext
{
    public TimeTrackerContext(DbContextOptions<TimeTrackerContext> options)
        : base(options)
    {
        //Database.EnsureCreated();
    }

    public DbSet<Project> Projects { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeActivity> Activities { get; set; }
    public DbSet<ActivityType> ActivityTypes { get; set; }
    public DbSet<EmployeeRole> EmployeeRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ConfigureContext();
        modelBuilder.SeedData();
    }
}