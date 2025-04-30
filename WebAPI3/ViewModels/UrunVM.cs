namespace WebAPI3.NewFolder
{
    public class UrunVM
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int KategoriId { get; set; } // tanımlamasak da olur
        public string KategoriAdi { get; set; } // Added property for category name
    }
}
