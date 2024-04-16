using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            
            return View(ProductList.Items);
        }
    }
}