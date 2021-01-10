using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PrintShop.Models;

namespace PrintShop.Controllers
{
    public class DeliveryAddressController : Controller
    {
        private PrintShopContext _context;

        // GET
        [Route("/myaddresses")]
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var addressesForCurrentUser = _context.DeliveryAddresses.Where(x => x.ClientId == userId).ToList();
            if (addressesForCurrentUser.Count() > 0 )
            {
                ViewData["addresses"] = addressesForCurrentUser;

                return View();
            }
            else
            {
                return RedirectToAction("New", "DeliveryAddress");
            }
            
        }

        public DeliveryAddressController(PrintShopContext printShopContext)
        {
            _context = printShopContext;
        }
        
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }


        [HttpPost]
        // Get /deliveryaddress/new
        public ActionResult New(DeliveryAddress deliveryAddress)
        {
            deliveryAddress.ClientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            // each client can have maximum 3 addresses
            if (_context.DeliveryAddresses.Count() == 0)
            {
                deliveryAddress.Id = 1.ToString();
            }
            else
            {
                deliveryAddress.Id = (1 + _context.DeliveryAddresses.Count()).ToString();
            }

            var x = 5;
            if (ModelState.IsValid)
            {
                _context.DeliveryAddresses.Add(deliveryAddress);

                _context.SaveChanges();

                return RedirectToAction("Index", "Order");

            }

            ViewData["Validation_message"] =
                "The county name should start with small letter. Also, for the moment we only deliver in Romania.";
            return RedirectToAction("New", "Order");
        }
    }
}