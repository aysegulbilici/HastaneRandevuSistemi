namespace HastaneRandevuSistemi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Randevu")]
    public class Randevu
    {
        [Key]
        [Required]
        [Column("id")]
        public int randevuId { get; set; }

        [Required]
        [Column("dilim")]
        public int randevuDilim { get; set; }

        [Required]
        [Column("kullanici_id")]
        [ForeignKey("FK_Randevu_Kullanici")]
        public int kullaniciId { get; set; }

        public Kullanici Kullanici { get; set; }

        [Required]
        [Column("doktor_id")]
        [ForeignKey("FK_Randevu_Doktor")]
        public int doktorId { get; set; }

        public Doktor Doktor { get; set; }

        [Required]
        [Column("tarih")]
        public DateTime tarih { get; set; }
    }
}
