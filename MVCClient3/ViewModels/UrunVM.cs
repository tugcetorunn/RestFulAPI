namespace MVCClient3.ViewModels
{
    public class UrunVM
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; } // Added property for category name
    }
}
