using Microsoft.EntityFrameworkCore;
using TimeTracker.DAL.Models;

namespace TimeTracker.DAL.Context;

public static class ModelBuilderExtensions
{
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
}