// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using FinTrack.Api.Models;

namespace FinTrack.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Alimentación", Icon = "🍕" },
            new Category { Id = 2, Name = "Transporte", Icon = "🚗" },
            new Category { Id = 3, Name = "Salario", Icon = "💼" }
        );

        mb.Entity<Transaction>()
            .Property(t => t.Amount)
            .HasColumnType("decimal(18,2)");   

        mb.Entity<Transaction>()
      .HasOne(t => t.User)
      .WithMany(u => u.Transactions)
      .HasForeignKey(t => t.UserId)
      .OnDelete(DeleteBehavior.Restrict); 

        mb.Entity<Transaction>()
            .HasOne(t => t.Category)
            .WithMany(c => c.Transactions)
            .HasForeignKey(t => t.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
/// <summary>