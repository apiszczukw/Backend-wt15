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


        public IActionResult Index()
        {
            var produkty = db.Products.ToList();

            ViewBag.prod = produkty;

            return View();
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