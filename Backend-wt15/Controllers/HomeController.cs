using Backend_wt15.DAL;
using Backend_wt15.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend_wt15.Controllers
{
    public class HomeController : Controller
    {
        SklepContext db;

        public HomeController(SklepContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var produkty = db.Products.ToList();

            ViewBag.prod = produkty;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            if(product.Id  == 0)
            {
                db.Products.Add(product);
            }
            else
            {
                db.Products.Update(product);

            }


            db.SaveChanges();


			ViewBag.prod = db.Products.ToList();

			return View();
        }

        public IActionResult Edit(int PK)
        {
            var produkt = new Product();

            if(PK > 0 )
            {
                produkt = db.Products.Find(PK);
            }


            return View(produkt);
        }

        public IActionResult Delete(int PK)
        {
            var produkt = db.Products.Find(PK);

            if(produkt != null)
            {
                db.Products.Remove(produkt);
                db.SaveChanges();

            }


			ViewBag.prod = db.Products.ToList();

			return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}