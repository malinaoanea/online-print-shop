using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PrintShop.Logic;
using PrintShop.Models;

namespace PrintShop.Controllers
{
    public class OrderController : Controller
    {
        private PrintShopContext _context;
        
        
        public OrderController(PrintShopContext printShopContext)
        {
            _context = printShopContext;
        }
        
        [Route("/placeorder")]
        public IActionResult Index()
        {
            string clientIt = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            // daca nu are produce in carucior da eroare
            var shoppingCartId = _context.ShoppingCarts.Where(c=> c.ClientId == clientIt).ToList()[0].Id;
            ViewData["shoppingCartId"] = shoppingCartId;
            var items = _context.CartItems.Where(c => c.CartId == shoppingCartId).ToList();

            var products = new List<Product>();
            foreach (var item in items)
            {
                Product product =
                    _context.Products.Where(product1 => product1.Id.ToString() == item.ProductId).ToList()[0];
                products.Add( product);
            }

            ViewData["items"] = products;
            ViewData["clientId"] = clientIt;

            var deliveryDetails = _context.DeliveryAddresses.Where(d => d.ClientId == clientIt).ToList();
            ViewData["delivery"] = deliveryDetails;
            return View();
        }

        public IActionResult OrderPlaced()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }


        [HttpPost]
        // Get /order/new
        public ActionResult New(Order order)
        {

            // order.Id = (_context.Orders.Count() + 1).ToString();
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);

                _context.SaveChanges();

                return RedirectToAction("Index", "DeliveryAddress");

            }
            
           
            return View(order);
        }
        
        [Route("/revieworder")]
        public ActionResult ReviewOrder(Order order, DeliveryAddress deliveryAddress)
        {
            string clientIt = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            // daca nu are produce in carucior da eroare
            var shoppingCartId = _context.ShoppingCarts.Where(c=> c.ClientId == clientIt).ToList()[0].Id;

            var items = _context.CartItems.Where(c => c.CartId == shoppingCartId).ToList();

            var products = new List<Product>();
            foreach (var item in items)
            {
                Product product =
                    _context.Products.Where(product1 => product1.Id.ToString() == item.ProductId).ToList()[0];
                products.Add( product);
            }

            ViewData["items"] = products;
            ViewData["address"] = deliveryAddress;
            
            
           
            return View(order);
        }
        
        public ActionResult UseThisAddress(string id)
        {
            // creates a first "virtual" product for a new user that keeps away from PK constraint
            string clientIt = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            // daca nu are produce in carucior da eroare
            var shoppingCartId = _context.ShoppingCarts.Where(c=> c.ClientId == clientIt).ToList()[0].Id;
            
            OrderPlacingLogic shoppingCartLogic = new OrderPlacingLogic(_context, clientIt, shoppingCartId);
            
            shoppingCartLogic.UseThisAddress(id);

            return RedirectToAction("OrderPlaced", OrderPlaced());
        }
        
        
    }
        
        
    
}