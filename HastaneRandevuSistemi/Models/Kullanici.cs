namespace HastaneRandevuSistemi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Kullanici")]
public class Kullanici
{
    [Key]
    [Required]
    [Column("KullaniciId")]
    public int KullaniciId { get; set; }
    [Column("KullaniciAdi")]
    public string KullaniciAdi { get; set; }
    [Column("Sifre")]
    public string Sifre { get; set; }
    [Column("Eposta")]
    public string Eposta { get; set; }
    [MaxLength(40)]
    [Column("AdSoyad")]
    public string AdSoyad { get; set; }
    [Column("Rol")]
    public string Rol { get; set; }

    // Bir kullanıcının aldığı randevular
    [ForeignKey("RandevuId")]
    public List<Randevu> Randevular { get; set; }
}

