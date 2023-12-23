using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HastaneRandevuSistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        // GET: api/<KullaniciController>
        [HttpGet]
        public IEnumerable<Kullanici> Get()
        {
            return HastaneRandevuSistemiDbContext.getInstance().KullaniciT.ToList();
        }

        // GET api/<KullaniciController>/5
        [HttpGet("{id}")]
        public Kullanici Get(int id)
        {
            return HastaneRandevuSistemiDbContext.getInstance().KullaniciT.FirstOrDefault(x=>x.KullaniciId==id) ;
        }

        // POST api/<KullaniciController>
        [HttpPost]
        public IActionResult Post([FromBody] Kullanici value)
        {
            HastaneRandevuSistemiDbContext.getInstance().KullaniciT.Add(value);
            HastaneRandevuSistemiDbContext.getInstance().SaveChanges();
            return Ok();
        }

        // PUT api/<KullaniciController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Kullanici value)
        {
            var willPut=HastaneRandevuSistemiDbContext.getInstance().KullaniciT.FirstOrDefault(x=>x.KullaniciId==value.KullaniciId);
            if (willPut is null)
                return NotFound();
            willPut.KullaniciId = value.KullaniciId;
            willPut.KullaniciAd = value.KullaniciAd;
            willPut.KullaniciSoyad = value.KullaniciSoyad;
            willPut.Tc = value.Tc;
            willPut.Sifre = value.Sifre;
            willPut.rolId = value.rolId;
            HastaneRandevuSistemiDbContext.getInstance().Update(willPut);
            HastaneRandevuSistemiDbContext.getInstance().SaveChanges();
            return Ok();

        }

        // DELETE api/<KullaniciController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ListK = HastaneRandevuSistemiDbContext.getInstance().KullaniciT.ToList();
            var willDelete = ListK.Where(k => k.KullaniciId == id).First();
            if (willDelete is null)
                return NotFound();
            ListK.Remove(willDelete);
            HastaneRandevuSistemiDbContext.getInstance().SaveChanges();
            return Ok();
        }
    }
}
