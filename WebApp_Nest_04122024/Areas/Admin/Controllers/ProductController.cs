using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using WebApp_Nest_04122024.DAL;
using WebApp_Nest_04122024.Models;

namespace WebApp_Nest_04122024.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        AppDbContext _db;

        public ProductController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            List<Tag> tags = _db.Tags.ToList();
            ViewBag.Tags = tags;

            List<TagProduct> tagproducts = _db.TagProducts.ToList();
            ViewBag.TagProducts = tagproducts;

            var products = _db.Products.Include(c=>c.Category).Include(b=>b.Company); 
            ViewBag.Product = products;
            return View();
        }



        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {

            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int id)
        {
            if (id == null) return NotFound();
            var product = _db.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product newProduct)
        {
            if (newProduct.Id == null) return NotFound();
            var exProduct = _db.Products.FirstOrDefault(p => p.Id == newProduct.Id);
            if (exProduct == null) return NotFound();
            exProduct.Name = newProduct.Name;
            exProduct.Price = newProduct.Price;
            exProduct.OldPrice = newProduct.OldPrice;
            exProduct.ImageUrl = newProduct.ImageUrl;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }









        public IActionResult Delete(int id) 
        {
            Product protuct = _db.Products.FirstOrDefault(c => c.Id == id);
            _db.Remove(protuct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
