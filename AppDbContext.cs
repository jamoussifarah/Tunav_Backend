using Microsoft.EntityFrameworkCore;
using TunavBackend.Models;
using TunavBackend.Seeders;

namespace TunavBackend
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProduitAvecDevis> ProduitsAvecDevis { get; set; }
        public DbSet<CaracteristiqueProduitAvecDevis> CaracteristiquesProduitAvecDevis { get; set; }
        public DbSet<ProduitSansDevis> ProduitsSansDevis { get; set; }
        public DbSet<CaracteristiqueProduitSansDevis> CaracteristiquesProduitSansDevis { get; set; }

        public DbSet<Devis> Devis { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ProductsSeeder.Seed(modelBuilder);
        }
    }
}
