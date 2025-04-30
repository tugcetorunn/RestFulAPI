namespace WebAPI3.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int KategoriId { get; set; }
        public Kategori? Kategori { get; set; } // Navigation property
    }
}
