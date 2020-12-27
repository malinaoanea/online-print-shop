using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrintShop.Areas.Identity.Data;
using PrintShop.Models;

namespace PrintShop.Controllers
{
    public class CategoryController : Controller
    {
        private PrintShopContext _context;

        public CategoryController(PrintShopContext printShopContext)
        {
            _context = printShopContext;
        }
        
        // GET 
        [Route("/sefu/categories")]
        public IActionResult CategoryIndex()
        {
            ViewData["categories"] = _context.Categories.ToList();
            return View(); 
        }
        
        // [Authorize(Roles = "Admin")]
        // [Route("/sefu/manage" )]
        [HttpGet]
        public IActionResult New(int categoryId = 0)
        {
            
            
            return View();
        }
        
        [HttpPost]
        // Get /category/new
        public ActionResult New(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);

                _context.SaveChanges();

                return RedirectToAction("CategoryIndex", "Category");
                //return Redirect("Index");
                //return View("Index");
            }   

            return View(category);
        }
        
        // GET: /category/edit/{id}
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: /category/edit
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var oldCategoryr = _context.Categories.Find(category.Id);

                    if (oldCategoryr == null)
                    {
                        return NotFound();
                    }

                    oldCategoryr.Name = category.Name;
                    oldCategoryr.Id = category.Id;
                    oldCategoryr.Description = category.Description;

                    TryUpdateModelAsync(oldCategoryr);

                    _context.SaveChanges();

                    return RedirectToAction("CategoryIndex", "Category");
                }
            }
            catch (Exception e)
            {
                return Json(new { error_message = e.Message });
            }

            return View(category);
        }
        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);

            _context.SaveChanges();

            return RedirectToAction("CategoryIndex", "Category");
        }

        
    }

    
}