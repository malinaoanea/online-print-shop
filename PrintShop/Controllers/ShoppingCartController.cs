using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrintShop.Logic;
using PrintShop.Models;

namespace PrintShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private PrintShopContext _context;

        [Route("/mycart")]
        public IActionResult ProductIndex()
        {
            var clientIt = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            // daca nu are produce in carucior da eroare
            var shoppingCarts = _context.ShoppingCarts.Where(c => c.ClientId == clientIt).ToList();

            if (shoppingCarts.Count <= 0) return RedirectToAction("EmptyCart", "ShoppingCart");
            {
                var shoppingCartId = shoppingCarts[0].Id;
            
                var items = _context.CartItems.Where(c => c.CartId == shoppingCartId).ToList();

                var products = items.Select(item => _context.Products.Where(product1 => product1.Id.ToString() == item.ProductId).ToList()[0]).ToList();

                ViewData["items"] = products;
                return View();
            }


        }
        
        public IActionResult EmptyCart()
        {
            return View();
        }

        public ShoppingCartController(PrintShopContext printShopContext)
        {
            _context = printShopContext;
        }

        public ActionResult DeleteCartItem(string id)
        {
            ShoppingCartLogic shoppingCartLogic = new ShoppingCartLogic(_context, User.FindFirstValue(ClaimTypes.NameIdentifier));
            
            shoppingCartLogic.DeleteCartItem(id);
            
            return RedirectToAction("ProductIndex", "ShoppingCart");
        }
    }
}