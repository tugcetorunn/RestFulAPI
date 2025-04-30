using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCClient3.Models;
using MVCClient3.ViewModels;
using System.Threading.Tasks;

namespace MVCClient3.Controllers
{
    public class UrunController : Controller
    {
        private readonly HttpClient client;
        private readonly IConfiguration configuration;
        string url = "";
        public UrunController(HttpClient _client, IConfiguration _configuration)
        {
            client = _client;
            configuration = _configuration;
            url = configuration.GetValue<string>("url");
        }
        public async Task<IActionResult> Listele()
        {
            // var url = configuration.GetValue<string>("url"); // str dönecek bilgisi veriliyor generic ile
            var data = await client.GetFromJsonAsync<List<UrunVM>>(url + "Urun/join");
            return View(data);
        }

        public async Task<IActionResult> Ekle()
        {
            // var url = configuration.GetValue<string>("url");
            var kategoriler = await client.GetFromJsonAsync<List<Kategori>>(url + "Kategori");
            UrunFormVM vm = new UrunFormVM
            {
                Kategoriler = new SelectList(await TumKategoriler(), "KategoriId", "KategoriAdi")
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(Urun urun)
        {
            // var url = configuration.GetValue<string>("url");
            if (ModelState.IsValid)
            {
                
                var result = await client.PostAsJsonAsync(url + "Urun", urun);
                if (result.IsSuccessStatusCode)
                {
                    // Kitap başarıyla eklendi
                    return RedirectToAction("Listele");
                }
                else
                {
                    // Hata durumu
                    ModelState.AddModelError("", "Kitap eklenirken bir hata oluştu.");
                    //ModelState.AddModelError("", );
                }
            }
            var kategoriler = await client.GetFromJsonAsync<List<Kategori>>("http://localhost:5094/api/Kategori");
            UrunFormVM vm = new UrunFormVM
            {
                Kategoriler = new SelectList(kategoriler, "KategoriId", "KategoriAdi")
            };
            return View(vm);
        }

        private async Task<List<Kategori>> TumKategoriler()
        {
            return await client.GetFromJsonAsync<List<Kategori>>(url + "Kategori");
        }
    }
}
