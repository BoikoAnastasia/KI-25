using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    [Route("calculator/index/{a?}/{b?}")]
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index(double a = 0, double b = 0)
        {
            return Content($"{a} + {b} = {a + b}", "text/plain");
        }
    }
}
