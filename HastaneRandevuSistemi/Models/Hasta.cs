﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HastaneRandevuSistemi.Models;


[Table("Hasta")]
public class Hasta
{
    [Key]
    [Required]
    [Column("id")]
    public int hastaId { get; set; }

    [ForeignKey("id")]
    public Kullanici Kullanici { get; set; }

   


    [Required]
    [Column("randevu_id")]
    public string randevuListesiMetin { get; set; }


}
