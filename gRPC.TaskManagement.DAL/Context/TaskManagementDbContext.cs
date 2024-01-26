using gRPC.TaskManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace gRPC.TaskManagement.DAL.Context;

public class TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options)
    : DbContext(options)
{
    public DbSet<TaskItem> Tasks => Set<TaskItem>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Comment> Comments => Set<Comment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}