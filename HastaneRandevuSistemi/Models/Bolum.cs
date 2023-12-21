namespace HastaneRandevuSistemi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("Bolum")]
public class Bolum
{
    [Key]
    [Required]
    [Column("id")]
    public int BolumId { get; set; }
    [MaxLength(20)]
    [Column("ad")]
    [Required]
    public string BolumAdi { get; set; }
}
