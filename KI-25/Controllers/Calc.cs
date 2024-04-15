using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    
        [ApiController]
        [Route("[controller]")]

        public class CalculatorController : Controller
        {
            [HttpGet("index/{num1?}/{num2?}/{operation?}")]
            public ActionResult<string> Calculate(string num1 = "0", string num2 = "0", string operation = "+")
            {
                double number1 = string.IsNullOrEmpty(num1) ? 0 : double.Parse(num1);
                double number2 = string.IsNullOrEmpty(num2) ? 0 : double.Parse(num2);

                double result;
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    default:
                        return BadRequest("Erorr52. Используйте +, -, *.");
                }

                return $"{num1} {operation} {num2} = {result}";
            }
        }

    }
