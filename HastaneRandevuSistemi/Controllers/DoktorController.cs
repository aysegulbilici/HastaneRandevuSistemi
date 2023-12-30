using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
public class DoktorM
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Sifre { get; set; }
    public string Tc { get; set; }
    public int RolId { get; set; }               
    public int BolumId { get; set; }
}

/* TODO: trying to post data and make crud. migration fault.
 {
    "ad":"Mustafa",
    "soyad":"biçer",
    "sifre":"abckder",
    "tc":"12345678912",
    "rolId":1,
    "bolumId":1
}*/

namespace HastaneRandevuSistemi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DoktorController : ControllerBase
    {
        HastaneRandevuSistemiDbContext context = HastaneRandevuSistemiDbContext.getInstance();
        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<Doktor> Get()
        {
            return context.DoktorT.ToList();
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doktor Get(int id)
        {
            var res = context.DoktorT.FirstOrDefault(x => x.id == id);


            return res;
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] DoktorM doktorM )
        {
         
            HastaneRandevuSistemiDbContext context = HastaneRandevuSistemiDbContext.getInstance();
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAd = doktorM.Ad;
            kullanici.KullaniciSoyad = doktorM.Soyad;
            kullanici.Sifre = doktorM.Sifre;
            kullanici.Tc = doktorM.Tc;
            kullanici.rolId = doktorM.RolId;

            context.KullaniciT.Add(kullanici);

            Doktor doktor = new Doktor();
            doktor.id = kullanici.KullaniciId;
            doktor.bolum_id = doktorM.BolumId;
            doktor.randevu_id = "";

            context.DoktorT.Add(doktor);
            
            context.SaveChanges();
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Doktor value)
        {
            var willPut = HastaneRandevuSistemiDbContext.getInstance().DoktorT.FirstOrDefault(x => x.id == id);
            if (willPut == null)
                return NotFound();
            willPut.bolum_id = value.bolum_id;
            willPut.Bolum = value.Bolum;
            willPut.id = value.id;
            willPut.randevu_id = value.randevu_id;
            HastaneRandevuSistemiDbContext.getInstance().Update(willPut);
            HastaneRandevuSistemiDbContext.getInstance().SaveChanges();
            return Ok();
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)

        {

            var willDelete = HastaneRandevuSistemiDbContext.getInstance().DoktorT.Where(x => x.id == id).First();
            if (willDelete == null)
                return NotFound();
            HastaneRandevuSistemiDbContext.getInstance().DoktorT.Remove(willDelete);
            HastaneRandevuSistemiDbContext.getInstance().SaveChanges();
            return Ok();
        }
    }
}
