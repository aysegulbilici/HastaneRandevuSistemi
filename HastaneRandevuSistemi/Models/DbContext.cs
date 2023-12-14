using Microsoft.EntityFrameworkCore;

namespace HastaneRandevuSistemi.Models
{
    // DbContext sınıfından türetilen ve veritabanı işlemlerini yöneten sınıf.
    public class RandevuDbContext : DbContext
    {
        // DbSet, veritabanındaki tablolara karşılık gelen varlık sınıflarını temsil eder.
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=myhost;Database=mydatabase;Username=myuser;Password=mypassword");
            }
            base.OnConfiguring(optionsBuilder);
        }


    }
}
