using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
           
    public class CalculatorController : Controller
    {
 public string Index(int num1, int num2, char operation)
            {

                switch (operation)
                {
                    case '+':
                        int plus = num1 + num2;
                        return plus.ToString();
                    case '-':
                        int minus = num1 - num2;
                        return minus.ToString();
                    case '*':
                        int multiplymultiplication = num1 * num2;
                        return multiplymultiplication.ToString();
                    default:
                        int def = num1 + num2;
                        return def.ToString();
                }
            }
        }
    
        public string Calculate(string num1, string num2)
            {

                double number1 = string.IsNullOrEmpty(num1) ? 0 : double.Parse(num1);
                double number2 = string.IsNullOrEmpty(num2) ? 0 : double.Parse(num2);
                double result = number1 + number2;

                return $"{num1} + {num2} = {result}";
            }
        }
    }
}
