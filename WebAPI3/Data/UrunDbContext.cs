using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPI3.Models;

namespace WebAPI3.Data
{
    public class UrunDbContext : DbContext
    {
        public UrunDbContext(DbContextOptions<UrunDbContext> options) : base(options)
        {
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=.; initial catalog=UrunApiDb; integrated security=true; trust server certificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kategori>()
                .HasData(new Kategori { KategoriId = 1, KategoriAdi = "Elektronik"},
                new Kategori { KategoriId = 2, KategoriAdi = "Hediyelik Eşya" },
                new Kategori { KategoriId = 3, KategoriAdi = "Kırtasiye" });
        }
    }
}
