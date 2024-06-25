using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Product(int Id)
        {
            return View(ProductList.Products[Id - 1]);
        }
    }
}