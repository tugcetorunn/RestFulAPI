using Microsoft.AspNetCore.Mvc;
using MVCClient.Models;

namespace MVCClient.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var jsonData = client.GetStringAsync("http://localhost:5039/api/Baslangic/Liste").Result;
            var json = client.GetFromJsonAsync<List<Product>>("http://localhost:5039/api/Baslangic/Liste").Result;
            return View(json);
        }
    }
}
