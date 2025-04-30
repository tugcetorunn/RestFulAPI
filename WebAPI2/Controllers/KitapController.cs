using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        public static List<Kitap> kitaplar = new List<Kitap> // ramde kayıtlı kalması için static olması lazım. ama program durdurulduğunda silinir.
        {
            new Kitap{ KitapId = 1, KitapAdi = "Sefiller", Yazar = "Victor Hugo", Fiyat = 500, Ozet = "..."},
            new Kitap{ KitapId = 2, KitapAdi = "Suç ve Ceza", Yazar = "Dostoyevski", Fiyat = 420, Ozet = "..."},
            new Kitap{ KitapId = 3, KitapAdi = "Denemeler", Yazar = "Montaigne", Fiyat = 500, Ozet = "..."},
        };

        [HttpGet("Listele")]
        public async Task<IActionResult> Listele()
        {
            if (kitaplar == null || kitaplar.Count == 0)
            {
                return NotFound("Kitap bulunamadı.");
            }
            return Ok(kitaplar);
        }

        [HttpGet("Bul")]
        public async Task<IActionResult> Bul(int id)
        {
            Kitap kitap = kitaplar.FirstOrDefault(k => k.KitapId == id); // find
            if (kitap == null)
            {
                return NotFound();
            }
            return Ok(kitap);
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(Kitap kitap)
        {
            if (kitap == null)
            {
                return BadRequest("Kitap bilgileri eksik.");
            }
            kitaplar.Add(kitap);
            return Ok(kitap);
        }
    }
}
