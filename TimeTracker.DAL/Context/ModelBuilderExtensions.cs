using Bogus;
using Microsoft.EntityFrameworkCore;
using TimeTracker.DAL.Models;

namespace TimeTracker.DAL.Context;

public static class ModelBuilderExtensions
{
    private static readonly int employeeCount = 10;
    private static readonly int projectCount = 5;
    private static readonly int employeeActivityCount = 100;

    public static void ConfigureContext(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>(entity =>
        {
            entity.Property(p => p.Id)
                .UseIdentityColumn();
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(p => p.StartDate)
                .IsRequired();
            entity.Property(p => p.EndDate)
                .IsRequired();
        });


        modelBuilder.Entity<EmployeeActivity>(entity =>
        {
            entity.Property(a => a.Id)
                .UseIdentityColumn();

            entity.Property(a => a.Date)
                .IsRequired();
            entity.Property(a => a.ProjectId)
                .IsRequired();
            entity.HasOne(a => a.Project)
                .WithMany(p => p.EmployeeActivities)
                .HasForeignKey(a => a.ProjectId);
            entity.HasOne(a => a.Employee)
                .WithMany(e => e.EmployeeActivities)
                .HasForeignKey(a => a.EmployeeId);
            entity.HasOne(a => a.ActivityType)
                .WithMany(at => at.EmployeeActivities)
                .HasForeignKey(a => a.ActivityTypeId);
            entity.HasOne(a => a.EmployeeRole)
                .WithMany(er => er.EmployeeActivities)
                .HasForeignKey(a => a.EmployeeRoleId);
        });

        modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.Property(a => a.Id)
                    .UseIdentityColumn();
                entity.HasIndex(a => a.Name)
                    .IsUnique();
            }
        );

        modelBuilder.Entity<EmployeeRole>(entity =>
        {
            entity.Property(role => role.Id)
                .UseIdentityColumn();
            entity.HasIndex(role => role.Name)
                .IsUnique();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(emp => emp.Id)
                .UseIdentityColumn();
            entity.Property(emp => emp.Name)
                .IsRequired()
                .HasMaxLength(200);
        });
    }

    public static void SeedData(this ModelBuilder modelBuilder)
    {
        var activityTypes = new List<ActivityType>
        {
            new() { Id = 1, Name = "Regular work" },
            new() { Id = 2, Name = "Overtime" },
            new() { Id = 3, Name = "Additional work" },
            new() { Id = 4, Name = "Voluntary" },
            new() { Id = 5, Name = "Training" },
            new() { Id = 6, Name = "Other" }
        };
        var employeeRoles = new List<EmployeeRole>
        {
            new() { Id = 1, Name = "Developer" },
            new() { Id = 2, Name = "QA" },
            new() { Id = 3, Name = "Business Analyst" },
            new() { Id = 4, Name = "Software Engineer" }
        };
        var employees = GenerateEmployees();
        var projects = GenerateProjects();
        var employeeActivities = GenerateEmployeeActivities(employeeRoles, activityTypes, employees, projects);
        modelBuilder.Entity<ActivityType>().HasData(activityTypes);
        modelBuilder.Entity<EmployeeRole>().HasData(employeeRoles);
        modelBuilder.Entity<Employee>().HasData(employees);
        modelBuilder.Entity<Project>().HasData(projects);
        modelBuilder.Entity<EmployeeActivity>().HasData(employeeActivities);
    }

    private static ICollection<Employee> GenerateEmployees()
    {
        var employeeId = 1;
        string[] genders =
        {
            "Female",
            "Male",
            "Non binary"
        };
        var bornInMin = new DateTime(1960, 1, 1);
        var bornInMax = DateTime.Now;
        var employee = new Faker<Employee>()
            .RuleFor(e => e.Id, f => employeeId++)
            .RuleFor(e => e.Name, f => f.Name.FullName())
            .RuleFor(e => e.Gender, f => f.PickRandom(genders))
            .RuleFor(e => e.Birthday, f => f.Date.Between(bornInMin, bornInMax));

        return employee.Generate(employeeCount);
    }

    private static ICollection<Project> GenerateProjects()
    {
        var projectId = 1;
        var createdInMin = new DateTime(2000, 1, 1);
        var createdInMax = DateTime.Now;
        var project = new Faker<Project>()
            .RuleFor(p => p.Id, f => projectId++)
            .RuleFor(p => p.Name, f => f.Lorem.Word())
            .RuleFor(p => p.StartDate, f => f.Date.Between(createdInMin, createdInMax))
            .RuleFor(p => p.EndDate, (f, p) => f.Date.Between(p.StartDate, createdInMax));
        return project.Generate(projectCount);
    }

    private static ICollection<EmployeeActivity> GenerateEmployeeActivities(
        ICollection<EmployeeRole> employeeRoles,
        ICollection<ActivityType> activityTypes,
        ICollection<Employee> employees,
        ICollection<Project> projects)
    {
        var employeeActivityId = 1;
        var empActivity = new Faker<EmployeeActivity>()
            .RuleFor(emp => emp.Id, f => employeeActivityId++)
            .RuleFor(emp => emp.Date,
                f => f.Date.Between(DateTime.Now.AddYears(-1), DateTime.Now))
            .RuleFor(emp => emp.EmployeeRoleId, f => f.PickRandom(employeeRoles).Id)
            .RuleFor(emp => emp.ActivityTypeId, f => f.PickRandom(activityTypes).Id)
            .RuleFor(emp => emp.EmployeeId, f => f.PickRandom(employees).Id)
            .RuleFor(emp => emp.ProjectId, f => f.PickRandom(projects).Id);
        return empActivity.Generate(employeeActivityCount);
    }
}