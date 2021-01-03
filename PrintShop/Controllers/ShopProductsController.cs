using Microsoft.AspNetCore.Mvc;

namespace PrintShop.Controllers
{
    public class ShopProductController : Controller
    {
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}