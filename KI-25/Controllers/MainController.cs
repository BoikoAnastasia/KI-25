using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
