namespace InventoryService.Infrastructure.Data;

using Microsoft.EntityFrameworkCore;
using CommonService.Models;
using InventoryService.Domain.Entities;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Unit> Units { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.IsSubclassOf(typeof(BaseEntity<>)))
            {
                modelBuilder.Entity(entityType.ClrType).Property(nameof(BaseEntity<int>.CreatedAt)).ValueGeneratedOnAdd();
                modelBuilder.Entity(entityType.ClrType).Property(nameof(BaseEntity<int>.CreatedBy)).IsRequired().ValueGeneratedOnAdd();
            }
        }
    }
}
