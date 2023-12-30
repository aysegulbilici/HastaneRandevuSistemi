using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class DoktorDbo
    {
        [MaxLength(20, ErrorMessage = "Ad alanı en fazla 20 karakter olmalıdır.")]
        [Required(ErrorMessage = "Ad zorunlu bir alan.")]
        [Column("KullaniciAd")] // Map to the correct column name if necessary
        public string KullaniciAd { get; set; }

        [MaxLength(20, ErrorMessage = "Soyad alanı en fazla 20 karakter olmalıdır.")]
        [Required(ErrorMessage = "Soyad zorunlu bir alan.")]
        [Column("KullaniciSoyad")] // Map to the correct column name if necessary
        public string KullaniciSoyad { get; set; }

        [MaxLength(11, ErrorMessage = "TC alanı en fazla 11 karakter olmalıdır.")]
        [Required(ErrorMessage = "TC zorunlu bir alan.")]
        [Column("Tc")] // Map to the correct column name if necessary
        public string Tc { get; set; }

        [MaxLength(20, ErrorMessage = "Şifre alanı en fazla 20 karakter olmalıdır.")]
        [Required(ErrorMessage = "Şifre zorunlu bir alan.")]
        [Column("Sifre")] // Map to the correct column name if necessary
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Bölüm ID zorunlu bir alan.")]
        [Column("bolum_id")] // Map to the correct column name if necessary
        public int bolumId { get; set; }

        private int rolId = 3;

        public string randevuListesiMetin = "";

        public Kullanici getKullanici()
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAd = KullaniciAd;
            kullanici.KullaniciSoyad = KullaniciSoyad;
            kullanici.Tc = Tc;
            kullanici.Sifre = Sifre;
            kullanici.rolId = rolId;
            return kullanici;
        }

        public Doktor getDoktor()
        {
            Doktor doktor = new Doktor();
            doktor.Kullanici = getKullanici();
            doktor.bolum_id = bolumId;
            
            return doktor;
        }


        public override string ToString()
        {
            return $"Doktor: {KullaniciAd} {KullaniciSoyad}, TC: {Tc}, BolumID: {bolumId}";
        }

    }
}
