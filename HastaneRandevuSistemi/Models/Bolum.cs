namespace HastaneRandevuSistemi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("Bolum")]
public class Bolum
{
    [Key]
    [Required]
    [Column("BolumId")]
    public int BolumId { get; set; }
    [MaxLength(20)]
    [Column("BolumAdi")]
    public string BolumAdi { get; set; }

    // Bir bölümdeki doktorlar
    [ForeignKey("DoktorId")]
    public List<Doktor> Doktorlar { get; set; }
}
