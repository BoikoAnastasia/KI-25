using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalcController : Controller
    {
        public string Index(int a, int b, string c)
        {
            switch (c)
            {
                case "+":
                    return $"{a} + {b} = {a + b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "*":
                    return $"{a} * {b} = {a * b}";
                case "/":
                    if (b != 0)
                    {
                        double result = (double)a / b;
                        return $"{a} / {b} = {result}";
                    }
                    else
                    {
                        return "На ноль делить нельзя!";
                    }
                default:
                    return "Операция не поддерживается";
            }
        }
    }
}
