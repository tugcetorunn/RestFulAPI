﻿namespace WebAPI3.Models
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public List<Urun>? Urunler { get; set; } // Navigation property
    }
}
