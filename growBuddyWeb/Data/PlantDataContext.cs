using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class PlantDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public PlantDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("PlantsDB"));
        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<FieldUnit> FieldUnits { get; set; }
        public DbSet<Preferences> Preferences { get; set; }
        public DbSet<Reading> Readings { get; set; }
    }
}
