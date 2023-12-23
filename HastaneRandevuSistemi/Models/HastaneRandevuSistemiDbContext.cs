using Microsoft.EntityFrameworkCore;

namespace HastaneRandevuSistemi.Models
{
    // DbContext sınıfından türetilen ve veritabanı işlemlerini yöneten sınıf.
    public class HastaneRandevuSistemiDbContext : DbContext
    {
        private static HastaneRandevuSistemiDbContext _instance;
        public  static HastaneRandevuSistemiDbContext getInstance() {
            if (_instance == null)
                _instance = new HastaneRandevuSistemiDbContext();
            return _instance;
        }
        // DbSet, veritabanındaki tablolara karşılık gelen varlık sınıflarını temsil eder.
        public DbSet<Randevu> RandevuT { get; set; }
        public DbSet<Admin> AdminT { get; set; }
        public DbSet<Bolum> BolumT { get; set; }
        public DbSet<Doktor> DoktorT { get; set; }
        public DbSet<Hasta> HastaT { get; set; }
        public DbSet<Kullanici> KullaniciT { get; set; }
        public DbSet<Rol> RolT { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(local)\SQLEXPRESS;Database=HastaneRandevuSistemi;Trusted_Connection=True;TrustServerCertificate=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
