using Microsoft.AspNetCore.Mvc.Rendering;
using MVCClient3.Models;

namespace MVCClient3.ViewModels
{
    public class UrunFormVM
    {
        public SelectList Kategoriler { get; set; }
        public Urun Urun { get; set; }
    }
}
