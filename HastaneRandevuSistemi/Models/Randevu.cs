namespace HastaneRandevuSistemi.Models;
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
    [Column("kullanici_id")]
    public int kullaniciId { get; set; }

    [ForeignKey("kullanici_id")]
    public Kullanici Kullanici { get; set; }

    

    [Required]
    [Column("doktor_id")]
    public int doktorId { get; set; }


    [ForeignKey("doktor_id")]
    public Doktor Doktor { get; set; }


    [Required]
    [Column("tarih")]
    public DateTime tarih { get; set; }
}
