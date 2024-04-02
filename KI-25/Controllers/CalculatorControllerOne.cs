using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    [Route("calculator/index/{a?}/{b?}/{operation?}")]
    public class CalculatorControllerOne : Controller
    {
        [HttpGet]
        public IActionResult Index(double a = 0, double b = 0, string operation = "+")
        {
            switch (operation)
            {
                case "+":
                    return Content($"{a} + {b} = {a + b}", "text/plain");
                case "-":
                    return Content($"{a} - {b} = {a - b}", "text/plain");
                case "*":
                    return Content($"{a} * {b} = {a * b}", "text/plain");
                default:
                    return Content("Неверная операция. Используйте + для сложения, - для вычитания или * для умножения.", "text/plain");
            }
        }
    }
}
