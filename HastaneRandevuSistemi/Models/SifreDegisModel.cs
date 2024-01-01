using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Models
{
    public class SifreDegisModel
    {
        public int id {  get; set; }
        public string EskiSifre {  get; set; }
        public string YeniSifre {  get; set; }
    }
}
