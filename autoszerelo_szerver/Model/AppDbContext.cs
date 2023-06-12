using Microsoft.EntityFrameworkCore;

namespace autoszerelo_szerver.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Munka> Items { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Munka> Munkak { get; set; }

    }
}