namespace HastaneRandevuSistemi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Doktor")]
public class Doktor 
{
    [Key]
    [Required] 
    [Column("id")]
    public int doktorId { get; set; }

    [ForeignKey("id")]
    public Kullanici Kullanici { get; set; }

    [Required]
    [Column("bolum_id")]
    public int bolumId { get; set; }

    [ForeignKey("bolum_id")]
    public Bolum Bolum { get; set; }


    [Required]
    [Column("randevu_id")]
    public string randevuListesiMetin { get; set; }



}
