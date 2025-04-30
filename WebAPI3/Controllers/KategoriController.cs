using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI3.Services;

namespace WebAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly KategoriService _kategoriService;
        public KategoriController(KategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var kategoriler = await _kategoriService.GetAllKategoriler();
            return Ok(kategoriler);
        }
    }
}
