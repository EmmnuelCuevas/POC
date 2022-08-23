using Microsoft.EntityFrameworkCore;
using RealState.Dtos;

namespace RealState.Context
{
    public class AppDbContext : DbContext
    {
        public IConfiguration _configuration;
        public AppDbContext(IConfiguration config)
        {
            _configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        public virtual DbSet<Step> Steps { get; set; }
    }
}
