using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        public string Calculate(string num1, string num2)
        {

            double number1 = string.IsNullOrEmpty(num1) ? 0 : double.Parse(num1);
            double number2 = string.IsNullOrEmpty(num2) ? 0 : double.Parse(num2);
            double result = number1 + number2;

            return $"{num1} + {num2} = {result}";
        }
    }
}
