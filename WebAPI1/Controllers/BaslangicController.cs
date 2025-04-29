using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaslangicController : ControllerBase
    {
        //[HttpGet] // verb yazmayınca swagger göstermiyor fakat restful bunu zorunlu tutmuyor urlden istek atınca çalışıyor
        //public string Test()
        //{
        //    return "test123";
        //}

        [HttpGet]
        public IActionResult Test()
        {
            return Ok("test123");
        }

        [HttpGet("Liste")]
        public IActionResult Listele()
        {
            List<Urun> urunler = new()
            {
                new Urun { UrunId = 1, UrunAdi = "kalem", Fiyat = 50 },
                new Urun { UrunId = 2, UrunAdi = "pergel", Fiyat = 120 },
                new Urun { UrunId = 3, UrunAdi = "silgi", Fiyat = 60 }
            };

            return Ok(urunler);
        }

        //[HttpPost]
        //public IActionResult Ekle([FromBody] Urun urun)
        //{
        //    if (urun == null)
        //    {
        //        return BadRequest("Ürün bilgileri eksik.");
        //    }
        //    // Ürünü ekleme işlemi burada yapılır (örneğin veritabanına ekleme)
        //    return CreatedAtAction(nameof(Listele), new { id = urun.UrunId }, urun);
        //}

        [HttpPost]
        public IActionResult Ekle(Urun urun)
        {
            return Ok("eklenen veri : " + urun.UrunAdi);
        }

        // client tarafında istek atmak için kullanılabilecek yöntemler: (client ı önyüz yapma yöntemleri (client html se))
        // xmlhttprequest - eski yöntem - request tipi xml eski uygulamalar hep xml kullaanıyordu
        // jquery ajax
        // fetch

        // axios
        // httpclient

        // httpclient - c# ile istemci tarafında istek atmak için kullanılır. .net core ile birlikte gelen bir kütüphane
        // httpclient ile istek atmak için öncelikle bir httpclient nesnesi oluşturulur. bu nesne ile istek atılır.

        // client console, windows, wpf, mvc... ise
        // httpclient ile istek atılır.
        // bu istek atılırken hangi url'e istek atılacağı belirtilir. bu url'e istek atılırken hangi method kullanılacağı belirtilir.
        // bu methodun hangi parametreleri alacağı belirtilir. bu parametreler istek atılırken gönderilir.
        // bu parametreler istek atılırken gönderilirken hangi formatta gönderileceği belirtilir. bu format json, xml, form-data olabilir.
        // bu format json ise istek atılırken json formatında gönderilir. bu format xml ise istek atılırken xml formatında gönderilir.
        // bu format form-data ise istek atılırken form-data formatında gönderilir.
        // 
    }
}
