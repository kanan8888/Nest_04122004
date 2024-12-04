using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApp_Nest_04122024.DAL;
using WebApp_Nest_04122024.Models;

namespace WebApp_Nest_04122024.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {   
            List<Category> categories = _db.Categories.ToList();
            ViewBag.Categoryes = categories;



            List<Product> products = _db.Products.Include(c=>c.Category).ToList();
            ViewBag.Products = products;



            List<Tag> tags = _db.Tags.ToList();
            ViewBag.Tags = tags;

            List<TagProduct> tagproducts = _db.TagProducts.ToList();
            ViewBag.TagProducts = tagproducts;

            return View();
        }

        







    }
}
