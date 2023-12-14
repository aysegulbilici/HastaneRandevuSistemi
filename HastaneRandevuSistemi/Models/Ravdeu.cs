namespace HastaneRandevuSistemi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("Randevu")]
public class Randevu
    
{
    [Key]
    [Required]
    [Column("RandevuId")]
    public int RandevuId { get; set; }
    [Column("KullaniciId")]
    public int KullaniciId { get; set; }
    [Column("DoktorId")]
    public int DoktorId { get; set; }
    [Timestamp]
    [Column("RandevuTarihi")]
    public DateTime RandevuTarihi { get; set; }

    // Bir randevunun sahibi (kullanıcı)
    [ForeignKey("KullaniciId")]
    public Kullanici Kullanici { get; set; }

    // Bir randevunun atanmış olduğu doktor
    [ForeignKey("DoktorId")]
    public Doktor Doktor { get; set; }
}
