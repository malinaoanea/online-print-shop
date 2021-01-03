using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrintShop.Models;

namespace PrintShop.Controllers
{
    public class ProductController : Controller
    {
        private PrintShopContext _context;

        // GET
        [Route("/sefu/products")]
        public IActionResult ProductIndex()
        {
            ViewData["products"] = _context.Products.ToList();
            return View();
        }

        public ProductController(PrintShopContext printShopContext)
        {
            _context = printShopContext;
        }

        // [Authorize(Roles = "Admin"
        [HttpGet]
        public IActionResult New(int categoryId = 0)
        {
            var categories = _context.Categories
                .Select(x => new
            {
                CategoryId = x.Id,
                CategoryName = x.Name
            }).ToList();

            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
            return View();
        }


        [HttpPost]
        // Get /product/new
        public ActionResult New(Product product)
        {
            
            
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);

                _context.SaveChanges();

                return RedirectToAction("ProductIndex", "Product");

            }
            
            var categories = _context.Categories
                .Select(x => new
                {
                    CategoryId = x.Id,
                    CategoryName = x.Name
                }).ToList();

            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName", product.CategoryId);
            
            return View(product);
        }

        // GET: /product/edit/{id}
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: /product/edit
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var oldProduct = _context.Products.Find(product.Id);

                    if (oldProduct == null)
                    {
                        return NotFound();
                    }

                    oldProduct.Name = oldProduct.Name;
                    oldProduct.Id = oldProduct.Id;
                    oldProduct.Category = oldProduct.Category;
                    oldProduct.ImageUrl = oldProduct.ImageUrl;
                    oldProduct.Price = oldProduct.Price;

                    TryUpdateModelAsync(oldProduct);

                    _context.SaveChanges();

                    return RedirectToAction("ProductIndex", "Product");
                }
            }
            catch (Exception e)
            {
                return Json(new {error_message = e.Message});
            }

            return View(product);
        }

        // Get: //product/displayandshopproduct
        public ActionResult DisplayAndShopProduct()
        {
            ViewData["products"] = _context.Products.ToList();
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);

            _context.SaveChanges();

            return RedirectToAction("ProductIndex", "Product");
            
        }
    }
}