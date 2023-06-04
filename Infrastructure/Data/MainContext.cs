using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Configurations;

namespace Infrastructure.Data;

public class MainContext : DbContext
{
    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<ExpenseItem> Expenses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}