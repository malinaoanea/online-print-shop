using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrintShop.Models;

namespace PrintShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private PrintShopContext _context;

        // GET
        public IActionResult ProductIndex()
        {
            return View();
        }

        public ShoppingCartController(PrintShopContext printShopContext)
        {
            _context = printShopContext;
        }

        // [Authorize(Roles = "Admin"
        [HttpGet]
        public IActionResult New(int categoryId = 0)
        {
            var shoppingCart = _context.ShoppingCarts
                .Select(x => new
                {
                    ShoppingcartId = x.Id,
                    ClientId = x.ClientId
                }).ToList();

            return View();
        }


        [HttpPost]
        // Get /product/new
        public ActionResult New(ShoppingCart shoppingCart)
        {
            
            
            if (ModelState.IsValid)
            {
                _context.ShoppingCarts.Add(shoppingCart);

                _context.SaveChanges();

                // return RedirectToAction("ProductIndex", "Product");

            }
            
            var shoppingCarts = _context.ShoppingCarts
                .Select(x => new
                {
                    ShoppingCartId = x.Id,
                    ClientId = x.ClientId
                }).ToList();

            
            return View(shoppingCart);
        }
    }
}