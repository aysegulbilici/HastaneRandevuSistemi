using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Models
{


    [Table("Admin")]
    public class Admin
    {

        [Key]
        [Required]
        [Column("id")]
        public int adminId { get; set; }
        [ForeignKey("id")]
        public Kullanici Kullanici { get; set; }


        [Required]
        [EmailAddress]
        [Column("eposta")]
        public string eposta { get; set; }
         


        [Required]
        [MaxLength(20)]
        [Column("sifre")]
        public string sifre { get; set; }

    }
}
