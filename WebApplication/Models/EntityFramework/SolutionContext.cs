using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models.EntityFramework
{
    public class SolutionContext : DbContext
    {
        public DbSet<Solution> Solutions { get; set; }
        
        public SolutionContext(DbContextOptions<SolutionContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //modelBuilder.Entity<User>().HasData();
        }
    }
}