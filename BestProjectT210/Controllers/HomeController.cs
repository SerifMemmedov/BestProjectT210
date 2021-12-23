using BestProjectT210.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BestProjectT210.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private T210ShopContext db=new T210ShopContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
         
            ViewData["ProductList"] =db.Products.ToList();
            ViewData["SliderList"] = db.Sliders.ToList();
            ViewData["BrendList"] = db.Brands.ToList();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["AboutSingle"] = db.Abouts.First();

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Salam";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}