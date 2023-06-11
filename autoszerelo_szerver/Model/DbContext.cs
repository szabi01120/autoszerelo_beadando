using Microsoft.EntityFrameworkCore;

namespace autoszerelo_munka_felvevo.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Munka> Munkafelvetel { get; set; }
    }
}
