namespace WebAPI2.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public decimal Fiyat { get; set; }
        public string Ozet { get; set; }
    }
}
