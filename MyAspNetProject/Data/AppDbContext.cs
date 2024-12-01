using Microsoft.EntityFrameworkCore;
using MyAspNetProject.Models;

namespace MyAspNetProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<YourEntity> YourEntities { get; set; } // Replace with your model
}
