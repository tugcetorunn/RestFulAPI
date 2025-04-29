using ConsoleClient.Models;
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");

Console.WriteLine("This is a console client for the API.");

Console.WriteLine("Başlangıç servisini kullan!!!");

//using (HttpClient client = new HttpClient())
//{
//    client.BaseAddress = new Uri("https://localhost:5001/api/");
//    client.DefaultRequestHeaders.Accept.Clear();
//    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
//    // GET isteği
//    HttpResponseMessage response = await client.GetAsync("Baslangic/Liste");
//    if (response.IsSuccessStatusCode)
//    {
//        var urunler = await response.Content.ReadAsAsync<List<Urun>>();
//        foreach (var urun in urunler)
//        {
//            Console.WriteLine($"Ürün ID: {urun.UrunId}, Ürün Adı: {urun.UrunAdi}, Fiyat: {urun.Fiyat}");
//        }
//    }
//}

HttpClient client = new HttpClient();
var jsonData = client.GetStringAsync("http://localhost:5039/api/Baslangic/Liste").Result;

var json = client.GetFromJsonAsync<List<Product>>("http://localhost:5039/api/Baslangic/Liste").Result;

foreach (var item in json)
{
    Console.WriteLine(item.UrunId + "-" + item.UrunAdi + "-" + item.Fiyat);
}

Console.WriteLine(jsonData); // api ın da ayağa kalkmış olması lazım. ayrıca görmek için buranın da aynı sln de olduğu için multiple startup projelerde çalıştırılması lazım.