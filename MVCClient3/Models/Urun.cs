using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCClient3.Models
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int KategoriId { get; set; }
        public Kategori? Kategori { get; set; }

    }
}
