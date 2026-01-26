using Microsoft.EntityFrameworkCore;
using trabajo_finall.Models;

namespace trabajo_finall.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
