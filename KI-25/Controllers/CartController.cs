using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CartController : Controller
    {
        public static List<int> ids;
        public IActionResult Cart() { 
            return View(); 
        }

        public IActionResult AddToCart(int Id)
        {
            if (ids == null)
            {
                ids = new List<int>();
            }
            ids.Add(Id - 1);
            return RedirectToAction("Cart", "Cart", new {id = ids.Count() });
        }
    }
}
