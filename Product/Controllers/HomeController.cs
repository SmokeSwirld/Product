using Microsoft.AspNetCore.Mvc;
using Product.Models;
using System.Diagnostics;

namespace Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            var products = new List<Product1>
    {
        new Product1
        {
            Name = "Juventus",
            Price = 120.21m,
            Image = "/img/Juventus.png",
            Description = "Рік заснування: 1897"
        },
        new Product1
        {
            Name = "Chelsea",
            Price = 90.99m,
            Image = "/img/Chelsea.png",
            Description = "Рік заснування:\t1905"
        },
        new Product1
        {
            Name = "Athletic",
            Price = 50.99m,
            Image = "/img/Athletic.png",
            Description = "Рік заснування: 1898"
        }
    };

            var productModel = new ProductModel
            {
                Products = products
            };

            return View(productModel);
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