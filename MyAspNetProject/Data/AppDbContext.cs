using Microsoft.EntityFrameworkCore;

namespace MyAspNetProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<YourEntity> YourEntities { get; set; } // Replace with your model
    }

    public class YourEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
