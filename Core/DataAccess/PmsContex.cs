using EFProj.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFProj.Core.DataAccess;

public class PmsContext : DbContext
{
    private readonly string _connString = "";
    public DbSet<Role> Roles { get; set; }   //access tables
    public DbSet<User> Users { get; set; }
    public DbSet<TaskData> Tasks { get; set; }
    public DbSet<TaskAttachment> TaskAttachments { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectCategory> ProjectCategories { get; set; }
    public PmsContext()
    {

    }
    public PmsContext(string connString)
    {
        _connString = connString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(_connString, ServerVersion.AutoDetect(_connString));  //configures the database used
    }
}
