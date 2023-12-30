using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Models
{
    [Table("Doktor")]
    public class Doktor
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Column("bolum_id")]
        public int bolum_id { get; set; }

        [Required]
        [Column("randevu_id")]
        public string randevu_id { get; set; }

        [ForeignKey("id")]
        public Kullanici Kullanici { get; set; }

        [ForeignKey("bolum_id")]
        public Bolum Bolum { get; set; }

        public string toString()
        {
            return $"id: {id}, bolum_id: {bolum_id}, randevu_id: {randevu_id}";
        }
    }
}
