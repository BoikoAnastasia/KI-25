using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;

namespace KI_25.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index(int id)
        {
           return View(ProductList.TryGetProduct(id));
        }
    }
}


