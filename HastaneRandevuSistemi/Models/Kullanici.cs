namespace HastaneRandevuSistemi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Kullanici")]
public class Kullanici
{
    [Key]
    [Required]
    [Column("id")]
    public int KullaniciId { get; set; }
    [MaxLength(20)]
    [Column("ad")]
    [Required]
    public string KullaniciAd { get; set; }
    [Column("soyad")]
    [MaxLength(20)]
    [Required]
    public string KullaniciSoyad { get; set; }
    [Column("sifre")]
    [MaxLength(20)]
    [Required]   
    public string Sifre { get; set; }
    [Column("tc")]
    [MaxLength(11)]
    [Required]
    public string Tc { get; set; }
    [Column("rol_id")]
    [Required]
    public int rolId { get; set; }

    
}

