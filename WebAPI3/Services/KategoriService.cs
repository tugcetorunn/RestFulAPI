using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAPI3.Data;
using WebAPI3.Models;

namespace WebAPI3.Services
{
    public class KategoriService
    {
        private readonly UrunDbContext _context;
        public KategoriService(UrunDbContext context)
        {
            _context = context;
        }
        public async Task<List<Kategori>> GetAllKategoriler()
        {
            return await _context.Kategoriler.ToListAsync();
        }

        public async Task<SelectList> KategoriSelectListOlustur()
        {
            return new SelectList(await GetAllKategoriler(), "KategoriId", "KategoriAdi");
        }
    }
}
