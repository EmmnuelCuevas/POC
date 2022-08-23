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
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=67.205.146.248;port=5432;Database=qa;User Id=postgres;Password=Delgado123;searchPath=dbo");
            }
        }

        public virtual DbSet<Step> Steps { get; set; }
    }
}
