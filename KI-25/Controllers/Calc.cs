using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class CalcController : Controller
    {
        public string Index(double? a, double? b, string c)
        {
            double numA = a ?? 0;
            double numB = b ?? 0;
            string operation = string.IsNullOrEmpty(c) ? "+" : c;

            double result;

            switch (operation)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    if (numB == 0)
                        return "Деление на ноль невозможно.";

                    result = numA / numB;
                    break;
                default:
                    return "Неправильно задана операция. Допустимые операции: +, -, *, /";
            }

            return $"{numA} {operation} {numB} = {result}";
        }
    }
}







