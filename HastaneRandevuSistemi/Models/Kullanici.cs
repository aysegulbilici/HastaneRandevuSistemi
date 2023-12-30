using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Models
{
    [Table("Kullanici")]
    public class Kullanici
    {
        [Key]
        [Required]
        [Column("id")]
        public int KullaniciId { get; set; }

        [MaxLength(20, ErrorMessage = "Ad alanı en fazla 20 karakter olmalıdır.")]
        [Column("ad")]
        [Required(ErrorMessage = "Ad zorunlu bir alan.")]
        public string KullaniciAd { get; set; }

        [MaxLength(20, ErrorMessage = "Soyad alanı en fazla 20 karakter olmalıdır.")]
        [Column("soyad")]
        [Required(ErrorMessage = "Soyad zorunlu bir alan.")]
        public string KullaniciSoyad { get; set; }

        [MaxLength(20, ErrorMessage = "Şifre alanı en fazla 20 karakter olmalıdır.")]
        [Column("sifre")]
        [Required(ErrorMessage = "Şifre zorunlu bir alan.")]
        public string Sifre { get; set; }

        [MaxLength(11, ErrorMessage = "TC alanı en fazla 11 karakter olmalıdır.")]
        [Column("tc")]
        [Required(ErrorMessage = "TC zorunlu bir alan.")]
        public string Tc { get; set; }

        [Required(ErrorMessage = "Rol ID zorunlu bir alan.")]
        [Column("rol_id")]
        public int rolId { get; set; }
    }
}
