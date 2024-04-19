using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;

namespace KI_25.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<Product>>("Cart");
            decimal totalCost = cart.Sum(product => product.Cost);
            ViewBag.TotalCost = totalCost;
            return View(cart);
        }
        public IActionResult AddToCart(int id)
        {
            var product = ProductList.TryGetProduct(id);

            if (HttpContext.Session.GetObjectFromJson<List<Product>>("Cart") == null)
            {
                List<Product> cart = new List<Product>();
                cart.Add(product);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            else
            {
                var cart = HttpContext.Session.GetObjectFromJson<List<Product>>("Cart");
                cart.Add(product);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }

            // Перенаправляем пользователя обратно на страницу продукта после добавления в корзину
            return RedirectToAction("index", "home", new { id = id });
        }
    }
}
