using Microsoft.AspNetCore.Mvc;
using MVCClient2.Models;
using System.Threading.Tasks;

namespace MVCClient2.Controllers
{
    public class KitapController : Controller
    {

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(Book book)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                var result = await client.PostAsJsonAsync("http://localhost:5086/api/Kitap", book);

                if(result.IsSuccessStatusCode)
                {
                    // Kitap başarıyla eklendi
                    return RedirectToAction("Listele");
                }
                else
                {
                    // Hata durumu
                    ModelState.AddModelError("", "Kitap eklenirken bir hata oluştu.");
                }
            }
            return View(book);
        }

        public async Task<IActionResult> Listele()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetFromJsonAsync<List<Book>>("http://localhost:5086/api/Kitap/Listele");
            return View(data);
        }
    }
}
