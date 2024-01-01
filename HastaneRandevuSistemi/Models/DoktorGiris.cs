using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class DoktorGiris
    {
        [MaxLength(11, ErrorMessage = "TC alanı en fazla 11 karakter olmalıdır.")]
        [Column("tc")]
        [Required(ErrorMessage = "TC zorunlu bir alan.")]
        public String Tc {get;set;}
        [MaxLength(20, ErrorMessage = "Şifre alanı en fazla 20 karakter olmalıdır.")]
        [Column("sifre")]
        [Required(ErrorMessage = "Şifre zorunlu bir alan.")]
        public String Sifre{get;set; }
    }
}
