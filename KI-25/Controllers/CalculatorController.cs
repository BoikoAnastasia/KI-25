using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        [Route("calculator/index/{num1?}/{num2?}")]
        public IActionResult Index(double num1 = 0, double num2 = 0)
        {


            return Content($"{num1}+{num2}= {num1 + num2}", "text/plain");
        }

        
    }
    
}
