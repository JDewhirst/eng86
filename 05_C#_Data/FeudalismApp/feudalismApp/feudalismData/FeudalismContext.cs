using Microsoft.EntityFrameworkCore;

namespace feudalismData
{
    public partial class FeudalismContext : DbContext
    {
        public static FeudalismContext Instance { get; } = new FeudalismContext();

        public DbSet<Character> Characters { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<TerrainDetail> TerrainDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = Southwind;");
            }
        }
    }
}
