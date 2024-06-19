using Microsoft.AspNetCore.Mvc;
using KI_25.Models;
using System.Linq;

namespace KI_25.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.0m },
            new Product { Id = 2, Name = "Product 2", Price = 20.0m }
        };

        private static Basket UserBasket = new Basket();

        public IActionResult Add()
        {
            return View(Products);
        }

        [HttpPost]
        public IActionResult AddToBasket(int productId)
        {
            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                UserBasket.Products.Add(product);
            }
            return RedirectToAction("Basket");
        }

        public IActionResult Basket()
        {
            return View(UserBasket);
        }

        [HttpPost]
        public IActionResult RemoveFromBasket(int productId)
        {
            var product = UserBasket.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                UserBasket.Products.Remove(product);
            }
            return RedirectToAction("Basket");
        }
    }
}
