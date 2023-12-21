using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HastaneRandevuSistemi.Models
{
    [Table("Rol")]
    public class Rol
    {

        [Key]
        [Required]
        [Column("id")]
        public int rolId { get; set; }
        [MaxLength(10)]
        [Required]
        [Column("rol")]
        public string rolAd { get; set; }
    }
}
