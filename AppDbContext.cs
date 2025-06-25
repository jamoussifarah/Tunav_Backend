using Microsoft.EntityFrameworkCore;
using TunavBackend.Models;

namespace TunavBackend
{
    public class AppDbContext : DbContext
    {   
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
