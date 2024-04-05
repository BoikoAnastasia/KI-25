using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    [Route("calculator/index/{a?}/{b?}/{operation?}")]
    public class CalculatorControllerOne : Controller
    {
        public string Calculate(int a, int b, string operation = "+")
        {
            int result;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                default:
                    return "Неизвестная операция";
            }
            return $"{a} {operation} {b} = {result}";
        }
    }
}