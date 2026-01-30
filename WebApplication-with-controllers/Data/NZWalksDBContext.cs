using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.EntityFrameworkCore;
using WebApplication_with_controllers.Models;
using WebApplication_with_controllers.Models.Domain;

namespace WebApplication_with_controllers.Data
{
    public class NZWalksDBContext : DbContext
    {
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options) : base(options)
        {
        }

        // Add your DbSet properties here
        // public DbSet<YourModel> YourModels { get; set; }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure your entities here
        }
    }
}