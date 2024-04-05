using Microsoft.AspNetCore.Mvc;

namespace CalculatorService.Controllers
{
    [Route("calc")]
    public class CalcController : Controller
    {
        
        [HttpGet("index")]
        public IActionResult Calculate(double a = 0, double b = 0, string c = "+")
        {
            switch (c)
            {
                case "+":
                    return Content($"{a} + {b} = {a + b}");
                case "-":
                    return Content($"{a} - {b} = {a - b}");
                case "*":
                    return Content($"{a} * {b} = {a * b}");
                case "/":
                    if (b == 0)
                        return Content("Ошибка: Деление на ноль невозможно.");
                    return Content($"{a} / {b} = {a / b}");
                default:
                    return Content("Ошибка: Неверная операция. Используйте +, -, * или /.");
            }
        }
    }
}
