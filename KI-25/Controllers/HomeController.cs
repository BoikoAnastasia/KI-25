using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IList<Product> Items { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var json = System.IO.File.ReadAllText(@"Product.json");
            Items = JsonConvert.DeserializeObject<IList<Product>>(json);

            var str = "";
            for (int i = 0; i < Items.Count; i++)
            {
                str += $"{Items[i].Id} {Items[i].Name} {Items[i].Price:C} {Items[i].Description} {Items[i].Category}\n";
            }

            ViewBag.ProductInfo = str;

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
