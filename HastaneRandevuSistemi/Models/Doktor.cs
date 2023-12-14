namespace HastaneRandevuSistemi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Doktor")]
public class Doktor
{
    [Key]
    [Required]
    [Column("DoktorId")]
    public int DoktorId { get; set; }
    [MaxLength(20)]
    [Column("DoktorAdi")]
    public string DoktorAdi { get; set; }

    // Bir doktorun atanmış olduğu bölüm
    [Column("BolumId")]
    public int BolumId { get; set; }
    [ForeignKey("BolumId")]
    public Bolum Bolum { get; set; }

    // Bir doktorun randevuları
    [ForeignKey("RandevuId")]
    public List<Randevu> Randevular { get; set; }
}
